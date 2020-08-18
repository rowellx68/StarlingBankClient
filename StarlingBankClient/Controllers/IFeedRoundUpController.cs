using System;
using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IFeedRoundUpController
    {
        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.RoundUpGoalResponse response from the API call</return>
        RoundUpGoalResponse FetchRoundUpGoal(Guid accountUid);

        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.RoundUpGoalResponse response from the API call</return>
        Task<RoundUpGoalResponse> FetchRoundUpGoalAsync(Guid accountUid);

        /// <summary>
        /// Activates transaction round-up and adds remainder to savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Round-up goal</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateActivateRoundUpGoal(Guid accountUid, RoundUpGoalPayload body);

        /// <summary>
        /// Activates transaction round-up and adds remainder to savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Round-up goal</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateActivateRoundUpGoalAsync(Guid accountUid, RoundUpGoalPayload body);

        /// <summary>
        /// Deletes the round-up goal associated with an account if one exists
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        void DeleteStopRoundUpGoal(Guid accountUid);

        /// <summary>
        /// Deletes the round-up goal associated with an account if one exists
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteStopRoundUpGoalAsync(Guid accountUid);

    }
} 