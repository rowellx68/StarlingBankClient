using System;
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
    public class PaymentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IPaymentsController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().Payments;
        }

        /// <summary>
        /// Get a payment order 
        /// </summary>
        [Test]
        public async Task TestGetPaymentOrder() 
        {
            // Parameters for the API call
            var paymentOrderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            PaymentOrderV2 result = null;

            try
            {
                result = await _controller.GetPaymentOrderAsync(paymentOrderUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestListStandingOrders() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            StandingOrdersResponse result = null;

            try
            {
                result = await _controller.ListStandingOrdersAsync(accountUid, categoryUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetStandingOrder() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var paymentOrderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            StandingOrder result = null;

            try
            {
                result = await _controller.GetStandingOrderAsync(accountUid, categoryUid, paymentOrderUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestCancelStandingOrder() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var paymentOrderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call

            try
            {
                await _controller.DeleteCancelStandingOrderAsync(accountUid, categoryUid, paymentOrderUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        ///
        ///Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestListNextPaymentDates() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var paymentOrderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            int? count = null;

            // Perform API call
            NextPaymentDatesResponse result = null;

            try
            {
                result = await _controller.ListNextPaymentDatesAsync(accountUid, categoryUid, paymentOrderUid, count);
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
        /// Get the payments associated with a payment order 
        /// </summary>
        [Test]
        public async Task TestGetPaymentOrderPayments() 
        {
            // Parameters for the API call
            var paymentOrderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            PaymentOrderPaymentsResponse result = null;

            try
            {
                result = await _controller.GetPaymentOrderPaymentsAsync(paymentOrderUid);
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