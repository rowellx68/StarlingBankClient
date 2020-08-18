using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IJointAccountsController
    {
        /// <summary>
        /// Get a joint account holder's details
        /// </summary>
        /// <return>Returns the Models.JointAccount response from the API call</return>
        JointAccount GetJointAccount();

        /// <summary>
        /// Get a joint account holder's details
        /// </summary>
        /// <return>Returns the Models.JointAccount response from the API call</return>
        Task<JointAccount> GetJointAccountAsync();

    }
} 