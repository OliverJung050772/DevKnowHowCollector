using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DKHC_Client.Models;

namespace DKHC_Client.Data
{
    public class DevCollApiService
    {
        public DevCollApiService()
        {
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            try
            {
                Console.WriteLine("Started http-request(member-list)...");
                IEnumerable<Member> memberList;
                using (HttpClient httpClient = new HttpClient(clientHandler))
                {
                    using (HttpResponseMessage response = await httpClient.GetAsync("https://localhost:5101/api/Members"))
                    {
                        response.EnsureSuccessStatusCode();
                        var jsonString = await response.Content.ReadAsStringAsync();
                        memberList = JsonConvert.DeserializeObject<IEnumerable<Member>>(jsonString);
                    }
                }
                Console.WriteLine("Finished http-request(member-list!)");
                return memberList;
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR: http-request(member-list) failed!\n" + exp.Message);
                return null;
            }
        }

        public async Task<Member> SaveNewMemberAsync(Member member)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            try
            {
                Console.WriteLine("Started http-post-request(add member)...");
                Member registeredMember;
                using (var httpClient = new HttpClient(clientHandler))
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(member), 
                        Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync("https://localhost:5101/api/Members", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        registeredMember = JsonConvert.DeserializeObject<Member>(apiResponse);
                    }    
                }
                Console.WriteLine("Finished http-post-request for new Member!");
                return registeredMember;
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR: post-request(add-member) failed!\n" + exp.Message);
                return null;
            }
        }
    }
}