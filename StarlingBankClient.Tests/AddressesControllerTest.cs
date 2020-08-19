using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBank.Controllers;
using StarlingBank.Exceptions;
using StarlingBank.Models;
using StarlingBank.Tests.Helpers;

namespace StarlingBank.Tests
{
    [TestFixture]
    public class AddressesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IAddressesController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().Addresses;
        }

        /// <summary>
        /// Get the account holder's addresses 
        /// </summary>
        [Test]
        public async Task TestGetAddresses() 
        {

            // Perform API call
            AddressesV2 result = null;

            try
            {
                result = await _controller.GetAddressesAsync();
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