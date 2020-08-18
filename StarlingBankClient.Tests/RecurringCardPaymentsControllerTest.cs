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
    public class RecurringCardPaymentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IRecurringCardPaymentsController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().RecurringCardPayments;
        }

        /// <summary>
        /// Fetch recurring card payments for an account holder 
        /// </summary>
        [Test]
        public async Task TestListRecurringPayments() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call
            RecurringCardPayment result = null;

            try
            {
                result = await _controller.ListRecurringPaymentsAsync(accountUid);
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