using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBankClient.Controllers;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Models;
using StarlingBankClient.Tests.Helpers;

namespace StarlingBankClient.Tests
{
    [TestFixture]
    public class DirectDebitMandatesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IDirectDebitMandatesController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().DirectDebitMandates;
        }

        /// <summary>
        /// Get the direct debit mandate with the specified identifier 
        /// </summary>
        [Test]
        public async Task TestGetMandate() 
        {
            // Parameters for the API call
            var mandateUid = GetMandateId();

            // Perform API call
            DirectDebitMandateV2 result = null;

            try
            {
                result = await _controller.GetMandateAsync(mandateUid);
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
        /// Cancel the direct debit mandate with the specified identifier 
        /// </summary>
        [Test]
        public async Task TestCancelMandate() 
        {
            // Parameters for the API call
            var mandateUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call

            try
            {
                await _controller.DeleteCancelMandateAsync(mandateUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Get a transaction history for a direct debit 
        /// </summary>
        [Test]
        public async Task TestListPaymentsForMandate() 
        {
            // Parameters for the API call
            var mandateUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var since = DateTime.ParseExact("2020-08-17", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            DirectDebitPaymentsResponse result = null;

            try
            {
                result = await _controller.ListPaymentsForMandateAsync(mandateUid, since);
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
        /// Get a list of direct debit mandates 
        /// </summary>
        [Test]
        public async Task TestListMandates() 
        {

            // Perform API call
            DirectDebitMandatesV2 result = null;

            try
            {
                result = await _controller.ListMandatesAsync();
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