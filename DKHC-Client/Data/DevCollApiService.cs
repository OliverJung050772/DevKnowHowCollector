using System;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<string> GetAllMembers()
        {
            try
            {
                Console.WriteLine("Started http-request...");
                HttpResponseMessage response = await _client.GetAsync("https://localhost:5101/api/Members");
                response.EnsureSuccessStatusCode();
                Console.WriteLine("Finished http-request!");
                return await response.Content.ReadAsStringAsync();
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR: http-request failed!\n" + exp.Message);
                return exp.Message;
            }
        }
    }
}