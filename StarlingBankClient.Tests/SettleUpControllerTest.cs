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
    public class SettleUpControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ISettleUpController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().SettleUp;
        }

        /// <summary>
        /// Fetch Settle Up profile for an account holder 
        /// </summary>
        [Test]
        public async Task TestGetSettleUpProfile() 
        {

            // Perform API call
            SettleUpProfile result = null;

            try
            {
                result = await _controller.GetSettleUpProfileAsync();
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