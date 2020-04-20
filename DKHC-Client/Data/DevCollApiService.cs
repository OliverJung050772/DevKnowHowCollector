using System;
using System.Linq;
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
        private readonly HttpClient _client;
        private IEnumerable<Member> _memberList;

        public DevCollApiService()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            _client = new HttpClient(clientHandler);
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            try
            {
                Console.WriteLine("Started http-request...");
                HttpResponseMessage response = await _client.GetAsync("https://localhost:5101/api/Members");
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Finished http-request!");
                var jsonString = await response.Content.ReadAsStringAsync();
                IEnumerable<Member> memberList = 
                    JsonConvert.DeserializeObject<IEnumerable<Member>>(jsonString);
                return memberList;
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR: http-request failed!\n" + exp.Message);
                return null;
            }
        }

        public async Task<Uri> SaveNewMemberAsync(Member member)
        {
            try
            {
                Console.WriteLine("Started http-post-request...");
                var content = JsonConvert.SerializeObject(member);
                HttpResponseMessage response = await 
                    _client.PostAsync("https://localhost:5101/api/Members", new StringContent(content));
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Finished http-post-request!");
                return response.Headers.Location;
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR: post-request failed!\n" + exp.Message);
                return null;
            }
        }
    }
}