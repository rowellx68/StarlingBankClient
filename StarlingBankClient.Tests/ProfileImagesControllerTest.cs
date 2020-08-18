using System;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBankClient.Controllers;
using StarlingBankClient.Exceptions;

namespace StarlingBankClient.Tests
{
    [TestFixture]
    public class ProfileImagesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IProfileImagesController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().ProfileImages;
        }

        /// <summary>
        /// Get a profile image if one exists 
        /// </summary>
        [Test]
        public async Task TestDownloadProfileImage() 
        {
            // Parameters for the API call
            var accountHolderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            dynamic result = null;

            try
            {
                result = await _controller.GetDownloadProfileImageAsync(accountHolderUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Delete a profile image if one exists 
        /// </summary>
        [Test]
        public async Task TestDeleteProfileImage() 
        {
            // Parameters for the API call
            var accountHolderUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call

            try
            {
                await _controller.DeleteProfileImageAsync(accountHolderUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}