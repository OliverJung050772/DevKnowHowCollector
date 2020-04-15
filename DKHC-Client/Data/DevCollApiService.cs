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
        private readonly IHttpClientFactory _clientFactory;
        private IEnumerable<Member> _memberList;

        public DevCollApiService(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;
            _memberList = Task.FromResult<IEnumerable<Member>>(GetAllMembers());
        }

        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://localhost:5101/api/Members");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var members = await JsonSerializer.DeserializeAsync
                    <IEnumerable<Member>>(responseStream);
                return members;
            }
            else
            {
                return Array.Empty<Member>();
            }
        }
    }
}