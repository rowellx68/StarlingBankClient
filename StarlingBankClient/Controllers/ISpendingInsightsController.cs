using System;
using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ISpendingInsightsController
    {
        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        SpendingCounterPartySummary GetQuerySpendingInsightsByCounterparty(Guid accountUid, string year, MonthEnum month);

        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        Task<SpendingCounterPartySummary> GetQuerySpendingInsightsByCounterpartyAsync(Guid accountUid, string year, MonthEnum month);

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        SpendingCategorySummary GetQuerySpendingInsightsBySpendingCategory(Guid accountUid, string year, MonthEnum month);

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        Task<SpendingCategorySummary> GetQuerySpendingInsightsBySpendingCategoryAsync(Guid accountUid, string year, MonthEnum month);

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        SpendingCountrySummary GetQuerySpendingInsightsByCountry(Guid accountUid, string year, MonthEnum month);

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        Task<SpendingCountrySummary> GetQuerySpendingInsightsByCountryAsync(Guid accountUid, string year, MonthEnum month);

    }
} 