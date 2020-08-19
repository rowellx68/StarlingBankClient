using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ISavingsGoalsController
    {
        /// <summary>
        /// Get a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalV2 response from the API call</return>
        SavingsGoalV2 GetSavingsGoal(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Get a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalV2 response from the API call</return>
        Task<SavingsGoalV2> GetSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        CreateOrUpdateSavingsGoalResponseV2 UpdateSavingsGoal(Guid accountUid, Guid savingsGoalUid, SavingsGoalRequestV2 body);

        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        Task<CreateOrUpdateSavingsGoalResponseV2> UpdateSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid, SavingsGoalRequestV2 body);

        /// <summary>
        /// Delete a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteSavingsGoal(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Delete a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Get all savings goals
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.SavingsGoalsV2 response from the API call</return>
        SavingsGoalsV2 GetSavingsGoals(Guid accountUid);

        /// <summary>
        /// Get all savings goals
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.SavingsGoalsV2 response from the API call</return>
        Task<SavingsGoalsV2> GetSavingsGoalsAsync(Guid accountUid);

        /// <summary>
        /// Create a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        CreateOrUpdateSavingsGoalResponseV2 CreateSavingsGoal(Guid accountUid, SavingsGoalRequestV2 body);

        /// <summary>
        /// Create a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        Task<CreateOrUpdateSavingsGoalResponseV2> CreateSavingsGoalAsync(Guid accountUid, SavingsGoalRequestV2 body);

        /// <summary>
        /// Get the photo associated with a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalPhotoV2 response from the API call</return>
        SavingsGoalPhotoV2 GetSavingsGoalPhoto(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Get the photo associated with a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalPhotoV2 response from the API call</return>
        Task<SavingsGoalPhotoV2> GetSavingsGoalPhotoAsync(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Add money into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Top up request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        SavingsGoalTransferResponseV2 AddMoney(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                TopUpRequestV2 body);

        /// <summary>
        /// Add money into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Top up request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        Task<SavingsGoalTransferResponseV2> AddMoneyAsync(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                TopUpRequestV2 body);

        /// <summary>
        /// Withdraw money from a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Withdrawal request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        SavingsGoalTransferResponseV2 UpdateWithdrawMoney(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                WithdrawalRequestV2 body);

        /// <summary>
        /// Withdraw money from a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Withdrawal request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        Task<SavingsGoalTransferResponseV2> UpdateWithdrawMoneyAsync(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                WithdrawalRequestV2 body);

        /// <summary>
        /// Get the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.ScheduledSavingsPaymentV2 response from the API call</return>
        ScheduledSavingsPaymentV2 GetRecurringTransfer(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Get the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.ScheduledSavingsPaymentV2 response from the API call</return>
        Task<ScheduledSavingsPaymentV2> GetRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Create a recurring transfer into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Recurring transfer request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        SavingsGoalTransferResponseV2 CreateOrUpdateRecurringTransfer(Guid accountUid, Guid savingsGoalUid, ScheduledSavingsPaymentRequestV2 body);

        /// <summary>
        /// Create a recurring transfer into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Recurring transfer request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        Task<SavingsGoalTransferResponseV2> CreateOrUpdateRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid, ScheduledSavingsPaymentRequestV2 body);

        /// <summary>
        /// Delete the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        void DeleteRecurringTransfer(Guid accountUid, Guid savingsGoalUid);

        /// <summary>
        /// Delete the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        Task DeleteRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid);

    }
} 