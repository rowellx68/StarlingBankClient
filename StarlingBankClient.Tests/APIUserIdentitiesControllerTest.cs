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
    public class APIUserIdentitiesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IAPIUserIdentitiesController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().APIUserIdentities;
        }

        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier. 
        /// </summary>
        [Test]
        public async Task TestGetTokenIdentity() 
        {

            // Perform API call
            IdentityV2 result = null;

            try
            {
                result = await _controller.GetTokenIdentityAsync();
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

        /// <summary>
        /// The individual who authorised the application 
        /// </summary>
        [Test]
        public async Task TestGetAuthorisingIndividual() 
        {

            // Perform API call
            Individual result = null;

            try
            {
                result = await _controller.GetAuthorisingIndividualAsync();
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

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens. 
        /// </summary>
        [Test]
        public async Task TestLogoutIndividual() 
        {

            // Perform API call

            try
            {
                await _controller.UpdateLogoutIndividualAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(202, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 202");

        }

    }
}