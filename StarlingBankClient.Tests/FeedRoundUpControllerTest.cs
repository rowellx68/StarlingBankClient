using System;
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
    public class FeedRoundUpControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IFeedRoundUpController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().FeedRoundUp;
        }

        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created 
        /// </summary>
        [Test]
        public async Task TestFetchRoundUpGoal() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call
            RoundUpGoalResponse result = null;

            try
            {
                result = await _controller.FetchRoundUpGoalAsync(accountUid);
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
        /// Deletes the round-up goal associated with an account if one exists 
        /// </summary>
        [Test]
        public async Task TestStopRoundUpGoal() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call

            try
            {
                await _controller.DeleteStopRoundUpGoalAsync(accountUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}