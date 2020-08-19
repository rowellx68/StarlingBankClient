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
    public class SavingsGoalsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ISavingsGoalsController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().SavingsGoals;
        }

        /// <summary>
        /// Get a savings goal 
        /// </summary>
        [Test]
        public async Task TestGetSavingsGoal() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var savingsGoalUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            SavingsGoalV2 result = null;

            try
            {
                result = await _controller.GetSavingsGoalAsync(accountUid, savingsGoalUid);
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
        /// Delete a savings goal 
        /// </summary>
        [Test]
        public async Task TestDeleteSavingsGoal() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var savingsGoalUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call

            try
            {
                await _controller.DeleteSavingsGoalAsync(accountUid, savingsGoalUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Get all savings goals 
        /// </summary>
        [Test]
        public async Task TestGetSavingsGoals() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call
            SavingsGoalsV2 result = null;

            try
            {
                result = await _controller.GetSavingsGoalsAsync(accountUid);
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
        /// Get the photo associated with a savings goal 
        /// </summary>
        [Test]
        public async Task TestGetSavingsGoalPhoto() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var savingsGoalUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            SavingsGoalPhotoV2 result = null;

            try
            {
                result = await _controller.GetSavingsGoalPhotoAsync(accountUid, savingsGoalUid);
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
        /// Get the recurring transfer of a savings goal 
        /// </summary>
        [Test]
        public async Task TestGetRecurringTransfer() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var savingsGoalUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            ScheduledSavingsPaymentV2 result = null;

            try
            {
                result = await _controller.GetRecurringTransferAsync(accountUid, savingsGoalUid);
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
        /// Delete the recurring transfer of a savings goal 
        /// </summary>
        [Test]
        public async Task TestDeleteRecurringTransfer() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var savingsGoalUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call

            try
            {
                await _controller.DeleteRecurringTransferAsync(accountUid, savingsGoalUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}