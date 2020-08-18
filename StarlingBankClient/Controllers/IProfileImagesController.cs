using System;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IProfileImagesController
    {
        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic GetDownloadProfileImage(Guid accountHolderUid);

        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> GetDownloadProfileImageAsync(Guid accountHolderUid);

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="body">Required parameter: Attachment input stream</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateProfileImage(Guid accountHolderUid, string contentType, object body);

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="body">Required parameter: Attachment input stream</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateProfileImageAsync(Guid accountHolderUid, string contentType, object body);

        /// <summary>
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteProfileImage(Guid accountHolderUid);

        /// <summary>
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteProfileImageAsync(Guid accountHolderUid);

    }
} 