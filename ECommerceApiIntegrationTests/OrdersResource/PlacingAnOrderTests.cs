using ECommerceApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ECommerceApiIntegrationTests.OrdersResource
{
    public class PlacingAnOrderTests : IClassFixture<WebApplicationFactory<Startup>>
    {

        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;
        public PlacingAnOrderTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task Gets201StatusCode()
        {
            var response = await _client.PostAsync("/orders", null);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
