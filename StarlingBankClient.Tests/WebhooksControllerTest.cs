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
    public class WebhooksControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IWebhooksController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().Webhooks;
        }

        /// <summary>
        /// Testcase for testing endpoint dispatchWebhook 
        /// </summary>
        [Test]
        public async Task TestDispatchWebhook() 
        {
            // Parameters for the API call
            DefaultWebhookPayloadModel body = null;

            // Perform API call

            try
            {
                await _controller.CreateDispatchWebhookAsync(body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>
            {
                {"Content-Type", "application/json"}
            };

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}