

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.Client;
using Intrinio.Model;

namespace Intrinio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompanyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Companies
        /// </summary>
        /// <remarks>
        /// Returns Companies matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        List<CompanySummary> FilterCompanies (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null);

        /// <summary>
        /// Filter Companies
        /// </summary>
        /// <remarks>
        /// Returns Companies matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        ApiResponse<List<CompanySummary>> FilterCompaniesWithHttpInfo (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null);
        /// <summary>
        /// Filter Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        List<Fundamental> FilterCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Filter Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        ApiResponse<List<Fundamental>> FilterCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        List<CompanySummary> GetAllCompanies (string nextPage = null);

        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        ApiResponse<List<CompanySummary>> GetAllCompaniesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Filings
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;FilingSummary&gt;</returns>
        List<FilingSummary> GetAllCompanyFilings (string identifier, string nextPage = null);

        /// <summary>
        /// Filings
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;FilingSummary&gt;</returns>
        ApiResponse<List<FilingSummary>> GetAllCompanyFilingsWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Get All Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        List<Fundamental> GetAllCompanyFundamentals (string identifier, string nextPage = null);

        /// <summary>
        /// Get All Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        ApiResponse<List<Fundamental>> GetAllCompanyFundamentalsWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Get a Company by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Company</returns>
        Company GetCompany (string identifier);

        /// <summary>
        /// Get a Company by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of Company</returns>
        ApiResponse<Company> GetCompanyWithHttpInfo (string identifier);
        /// <summary>
        /// Get Company Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetCompanyDataPointNumber (string identifier, string item);

        /// <summary>
        /// Get Company Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetCompanyDataPointNumberWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Company Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>DataPointText</returns>
        DataPointText GetCompanyDataPointText (string identifier, string item);

        /// <summary>
        /// Get Company Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetCompanyDataPointTextWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Company Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        List<HistoricalData> GetCompanyHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Company Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        ApiResponse<List<HistoricalData>> GetCompanyHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// News
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanyNews&gt;</returns>
        List<CompanyNews> GetNews (string identifier, string nextPage = null);

        /// <summary>
        /// News
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanyNews&gt;</returns>
        ApiResponse<List<CompanyNews>> GetNewsWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Lookup a Fundamental for a Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        List<Fundamental> LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup a Fundamental for a Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        ApiResponse<List<Fundamental>> LookupCompanyFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        List<CompanySummary> SearchCompanies (string query, string nextPage = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        ApiResponse<List<CompanySummary>> SearchCompaniesWithHttpInfo (string query, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Companies
        /// </summary>
        /// <remarks>
        /// Returns Companies matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        System.Threading.Tasks.Task<List<CompanySummary>> FilterCompaniesAsync (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null);

        /// <summary>
        /// Filter Companies
        /// </summary>
        /// <remarks>
        /// Returns Companies matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> FilterCompaniesAsyncWithHttpInfo (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null);
        /// <summary>
        /// Filter Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        System.Threading.Tasks.Task<List<Fundamental>> FilterCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Filter Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> FilterCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        System.Threading.Tasks.Task<List<CompanySummary>> GetAllCompaniesAsync (string nextPage = null);

        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> GetAllCompaniesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Filings
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;FilingSummary&gt;</returns>
        System.Threading.Tasks.Task<List<FilingSummary>> GetAllCompanyFilingsAsync (string identifier, string nextPage = null);

        /// <summary>
        /// Filings
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FilingSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FilingSummary>>> GetAllCompanyFilingsAsyncWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Get All Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        System.Threading.Tasks.Task<List<Fundamental>> GetAllCompanyFundamentalsAsync (string identifier, string nextPage = null);

        /// <summary>
        /// Get All Fundamentals for a Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> GetAllCompanyFundamentalsAsyncWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Get a Company by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of Company</returns>
        System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier);

        /// <summary>
        /// Get a Company by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Company)</returns>
        System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Company Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetCompanyDataPointNumberAsync (string identifier, string item);

        /// <summary>
        /// Get Company Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetCompanyDataPointNumberAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Company Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetCompanyDataPointTextAsync (string identifier, string item);

        /// <summary>
        /// Get Company Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetCompanyDataPointTextAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Company Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        System.Threading.Tasks.Task<List<HistoricalData>> GetCompanyHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Company Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// News
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanyNews&gt;</returns>
        System.Threading.Tasks.Task<List<CompanyNews>> GetNewsAsync (string identifier, string nextPage = null);

        /// <summary>
        /// News
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanyNews&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CompanyNews>>> GetNewsAsyncWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Lookup a Fundamental for a Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        System.Threading.Tasks.Task<List<Fundamental>> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup a Fundamental for a Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> LookupCompanyFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        System.Threading.Tasks.Task<List<CompanySummary>> SearchCompaniesAsync (string query, string nextPage = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> SearchCompaniesAsyncWithHttpInfo (string query, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompanyApi : ICompanyApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompanyApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompanyApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Intrinio.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Filter Companies Returns Companies matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        public List<CompanySummary> FilterCompanies (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = FilterCompaniesWithHttpInfo(lastFilingDate, sic, template, sector, industryCategory, industryGroup, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Companies Returns Companies matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        public ApiResponse< List<CompanySummary> > FilterCompaniesWithHttpInfo (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)
        {

            var localVarPath = "/companies/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lastFilingDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "last_filing_date", lastFilingDate)); // query parameter
            if (sic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sic", sic)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (sector != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sector", sector)); // query parameter
            if (industryCategory != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_category", industryCategory)); // query parameter
            if (industryGroup != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group", industryGroup)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

        /// <summary>
        /// Filter Companies Returns Companies matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<CompanySummary>> FilterCompaniesAsync (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = await FilterCompaniesAsyncWithHttpInfo(lastFilingDate, sic, template, sector, industryCategory, industryGroup, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Companies Returns Companies matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lastFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> FilterCompaniesAsyncWithHttpInfo (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)
        {

            var localVarPath = "/companies/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lastFilingDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "last_filing_date", lastFilingDate)); // query parameter
            if (sic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sic", sic)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (sector != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sector", sector)); // query parameter
            if (industryCategory != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_category", industryCategory)); // query parameter
            if (industryGroup != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group", industryGroup)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

        /// <summary>
        /// Filter Fundamentals for a Company Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        public List<Fundamental> FilterCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<List<Fundamental>> localVarResponse = FilterCompanyFundamentalsWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Fundamentals for a Company Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        public ApiResponse< List<Fundamental> > FilterCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->FilterCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Filter Fundamentals for a Company Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        public async System.Threading.Tasks.Task<List<Fundamental>> FilterCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<List<Fundamental>> localVarResponse = await FilterCompanyFundamentalsAsyncWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Fundamentals for a Company Returns Fundamentals for the Company with the given &#x60;identifier&#x60; and matching the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> FilterCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->FilterCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Get All Companies 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        public List<CompanySummary> GetAllCompanies (string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = GetAllCompaniesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Companies 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        public ApiResponse< List<CompanySummary> > GetAllCompaniesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/companies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

        /// <summary>
        /// Get All Companies 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<CompanySummary>> GetAllCompaniesAsync (string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = await GetAllCompaniesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Companies 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> GetAllCompaniesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/companies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

        /// <summary>
        /// Filings Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;FilingSummary&gt;</returns>
        public List<FilingSummary> GetAllCompanyFilings (string identifier, string nextPage = null)
        {
             ApiResponse<List<FilingSummary>> localVarResponse = GetAllCompanyFilingsWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filings Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;FilingSummary&gt;</returns>
        public ApiResponse< List<FilingSummary> > GetAllCompanyFilingsWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetAllCompanyFilings");

            var localVarPath = "/companies/{identifier}/filings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FilingSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FilingSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FilingSummary>)));
        }

        /// <summary>
        /// Filings Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;FilingSummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<FilingSummary>> GetAllCompanyFilingsAsync (string identifier, string nextPage = null)
        {
             ApiResponse<List<FilingSummary>> localVarResponse = await GetAllCompanyFilingsAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filings Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FilingSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FilingSummary>>> GetAllCompanyFilingsAsyncWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetAllCompanyFilings");

            var localVarPath = "/companies/{identifier}/filings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FilingSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FilingSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FilingSummary>)));
        }

        /// <summary>
        /// Get All Fundamentals for a Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        public List<Fundamental> GetAllCompanyFundamentals (string identifier, string nextPage = null)
        {
             ApiResponse<List<Fundamental>> localVarResponse = GetAllCompanyFundamentalsWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Fundamentals for a Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        public ApiResponse< List<Fundamental> > GetAllCompanyFundamentalsWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetAllCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Get All Fundamentals for a Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        public async System.Threading.Tasks.Task<List<Fundamental>> GetAllCompanyFundamentalsAsync (string identifier, string nextPage = null)
        {
             ApiResponse<List<Fundamental>> localVarResponse = await GetAllCompanyFundamentalsAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Fundamentals for a Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> GetAllCompanyFundamentalsAsyncWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetAllCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Get a Company by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Company</returns>
        public Company GetCompany (string identifier)
        {
             ApiResponse<Company> localVarResponse = GetCompanyWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Company by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of Company</returns>
        public ApiResponse< Company > GetCompanyWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompany");

            var localVarPath = "/companies/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Get a Company by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of Company</returns>
        public async System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier)
        {
             ApiResponse<Company> localVarResponse = await GetCompanyAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Company by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Company)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompany");

            var localVarPath = "/companies/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Get Company Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetCompanyDataPointNumber (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetCompanyDataPointNumberWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetCompanyDataPointNumberWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyDataPointNumber");

            var localVarPath = "/companies/{identifier}/data_point/{item}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Company Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetCompanyDataPointNumberAsync (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetCompanyDataPointNumberAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetCompanyDataPointNumberAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyDataPointNumber");

            var localVarPath = "/companies/{identifier}/data_point/{item}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Company Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetCompanyDataPointText (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = GetCompanyDataPointTextWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetCompanyDataPointTextWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyDataPointText");

            var localVarPath = "/companies/{identifier}/data_point/{item}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Company Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetCompanyDataPointTextAsync (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = await GetCompanyDataPointTextAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetCompanyDataPointTextAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyDataPointText");

            var localVarPath = "/companies/{identifier}/data_point/{item}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Company Historical Data Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        public List<HistoricalData> GetCompanyHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = GetCompanyHistoricalDataWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Historical Data Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        public ApiResponse< List<HistoricalData> > GetCompanyHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyHistoricalData");

            var localVarPath = "/companies/{identifier}/historical_data/{item}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get Company Historical Data Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        public async System.Threading.Tasks.Task<List<HistoricalData>> GetCompanyHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = await GetCompanyHistoricalDataAsyncWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company Historical Data Returns historical values for the given &#x60;item&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">Item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling CompanyApi->GetCompanyHistoricalData");

            var localVarPath = "/companies/{identifier}/historical_data/{item}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (item != null) localVarPathParams.Add("item", Configuration.ApiClient.ParameterToString(item)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// News Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanyNews&gt;</returns>
        public List<CompanyNews> GetNews (string identifier, string nextPage = null)
        {
             ApiResponse<List<CompanyNews>> localVarResponse = GetNewsWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// News Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanyNews&gt;</returns>
        public ApiResponse< List<CompanyNews> > GetNewsWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetNews");

            var localVarPath = "/companies/{identifier}/news";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanyNews>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanyNews>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanyNews>)));
        }

        /// <summary>
        /// News Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanyNews&gt;</returns>
        public async System.Threading.Tasks.Task<List<CompanyNews>> GetNewsAsync (string identifier, string nextPage = null)
        {
             ApiResponse<List<CompanyNews>> localVarResponse = await GetNewsAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// News Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanyNews&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CompanyNews>>> GetNewsAsyncWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetNews");

            var localVarPath = "/companies/{identifier}/news";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanyNews>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanyNews>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanyNews>)));
        }

        /// <summary>
        /// Lookup a Fundamental for a Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        public List<Fundamental> LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<List<Fundamental>> localVarResponse = LookupCompanyFundamentalWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup a Fundamental for a Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        public ApiResponse< List<Fundamental> > LookupCompanyFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling CompanyApi->LookupCompanyFundamental");

            var localVarPath = "/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (statementCode != null) localVarPathParams.Add("statement_code", Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Lookup a Fundamental for a Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        public async System.Threading.Tasks.Task<List<Fundamental>> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<List<Fundamental>> localVarResponse = await LookupCompanyFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup a Fundamental for a Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> LookupCompanyFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling CompanyApi->LookupCompanyFundamental");

            var localVarPath = "/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (statementCode != null) localVarPathParams.Add("statement_code", Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;CompanySummary&gt;</returns>
        public List<CompanySummary> SearchCompanies (string query, string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = SearchCompaniesWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;CompanySummary&gt;</returns>
        public ApiResponse< List<CompanySummary> > SearchCompaniesWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->SearchCompanies");

            var localVarPath = "/companies/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;CompanySummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<CompanySummary>> SearchCompaniesAsync (string query, string nextPage = null)
        {
             ApiResponse<List<CompanySummary>> localVarResponse = await SearchCompaniesAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CompanySummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CompanySummary>>> SearchCompaniesAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->SearchCompanies");

            var localVarPath = "/companies/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CompanySummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CompanySummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CompanySummary>)));
        }

    }
}
