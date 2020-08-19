using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBank.Controllers;
using StarlingBank.Exceptions;
using StarlingBank.Models;
using StarlingBank.Tests.Helpers;

namespace StarlingBank.Tests
{
    [TestFixture]
    public class PayeesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IPayeesController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().Payees;
        }

        /// <summary>
        /// Get an account holder's payees 
        /// </summary>
        [Test]
        public async Task TestGetPayees() 
        {

            // Perform API call
            Payees result = null;

            try
            {
                result = await _controller.GetPayeesAsync();
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
        /// Get scheduled payments 
        /// </summary>
        [Test]
        public async Task TestListPaymentOrdersForAccount() 
        {
            // Parameters for the API call
            var payeeUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var accountUid = GetAccountId();

            // Perform API call
            ScheduledPayments result = null;

            try
            {
                result = await _controller.ListPaymentOrdersForAccountAsync(payeeUid, accountUid);
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
        /// Deletes a payee 
        /// </summary>
        [Test]
        public async Task TestDeletePayee() 
        {
            // Parameters for the API call
            var payeeUid = GetPayeeId();

            // Perform API call

            try
            {
                await _controller.DeletePayeeAsync(payeeUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(204, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 204");

        }

        /// <summary>
        /// Delete a payee account 
        /// </summary>
        [Test]
        public async Task TestDeletePayeeAccount() 
        {
            // Parameters for the API call
            var payeeUid = GetPayeeId();
            var accountUid = GetAccountId();

            // Perform API call

            try
            {
                await _controller.DeletePayeeAccountAsync(payeeUid, accountUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(204, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 204");

        }

        /// <summary>
        /// View a history of payments to your payee 
        /// </summary>
        [Test]
        public async Task TestListPaymentsForPayeeAccount() 
        {
            // Parameters for the API call
            var payeeUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var accountUid = GetAccountId();
            var since = DateTime.ParseExact("2020-08-17", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Payments result = null;

            try
            {
                result = await _controller.ListPaymentsForPayeeAccountAsync(payeeUid, accountUid, since);
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
        /// Serves the image for the payee 
        /// </summary>
        [Test]
        public async Task TestServePayeeImageFile() 
        {
            // Parameters for the API call
            var payeeUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            dynamic result = null;

            try
            {
                result = await _controller.GetServePayeeImageFileAsync(payeeUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}