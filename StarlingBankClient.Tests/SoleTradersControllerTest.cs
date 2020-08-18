using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBankClient.Controllers;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Models;
using StarlingBankClient.Tests.Helpers;

namespace StarlingBankClient.Tests
{
    [TestFixture]
    public class SoleTradersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ISoleTradersController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().SoleTraders;
        }

        /// <summary>
        /// Get sole trader business details 
        /// </summary>
        [Test]
        public async Task TestGetSoleTrader() 
        {

            // Perform API call
            SoleTrader result = null;

            try
            {
                result = await _controller.GetSoleTraderAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}