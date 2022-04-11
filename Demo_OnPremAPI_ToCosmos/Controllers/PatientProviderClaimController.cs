using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoEntityAndDTO;
using Microsoft.Azure.Cosmos;

namespace Demo_OnPremAPI_ToCosmos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientProviderClaimController : ControllerBase
    {
        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = "https://vinayakcosmosdb.documents.azure.com:443/";

        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = "HDxdUMmhEB2d53nFNmHVCAqOnDCBkn5u8K9y8HY1Sjp2R9gdJE8i3WjVGmuFLW27Gw5oqnzywW5r2coRQWeXfg==";

        // The Cosmos client instance
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Container container;

        // The name of the database and container we will create
        private string databaseId = "CoffeeJoint_ClientProvider_Data";
        private string containerId = "OrangeBoosterProviders1";

        // GET: api/PatientProviderClaim
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PatientProviderClaim/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PatientProviderClaim
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PatientProviderClaim/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
