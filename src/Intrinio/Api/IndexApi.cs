

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
    public interface IIndexApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get ALl Economic Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;EconomicIndexSummary&gt;</returns>
        List<EconomicIndexSummary> GetAllEconomicIndices (string nextPage = null);

        /// <summary>
        /// Get ALl Economic Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;EconomicIndexSummary&gt;</returns>
        ApiResponse<List<EconomicIndexSummary>> GetAllEconomicIndicesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get All SIC Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;SICIndex&gt;</returns>
        List<SICIndex> GetAllSicIndices (string nextPage = null);

        /// <summary>
        /// Get All SIC Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;SICIndex&gt;</returns>
        ApiResponse<List<SICIndex>> GetAllSicIndicesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get All Stock Market Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StockMarketIndexSummary&gt;</returns>
        List<StockMarketIndexSummary> GetAllStockMarketIndices (string nextPage = null);

        /// <summary>
        /// Get All Stock Market Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StockMarketIndexSummary&gt;</returns>
        ApiResponse<List<StockMarketIndexSummary>> GetAllStockMarketIndicesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get an Economic Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>EconomicIndex</returns>
        EconomicIndex GetEconomicIndexById (string identifier);

        /// <summary>
        /// Get an Economic Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of EconomicIndex</returns>
        ApiResponse<EconomicIndex> GetEconomicIndexByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get Economic Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetEconomicIndexDataPointNumber (string identifier, string item);

        /// <summary>
        /// Get Economic Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetEconomicIndexDataPointNumberWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Economic Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        DataPointText GetEconomicIndexDataPointText (string identifier, string item);

        /// <summary>
        /// Get Economic Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetEconomicIndexDataPointTextWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Economic Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        List<HistoricalData> GetEconomicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get Economic Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        ApiResponse<List<HistoricalData>> GetEconomicIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Get an SIC Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>SICIndex</returns>
        SICIndex GetSicIndexById (string identifier);

        /// <summary>
        /// Get an SIC Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of SICIndex</returns>
        ApiResponse<SICIndex> GetSicIndexByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get SIC Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetSicIndexDataPointNumber (string identifier, string item);

        /// <summary>
        /// Get SIC Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetSicIndexDataPointNumberWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get SIC Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        DataPointText GetSicIndexDataPointText (string identifier, string item);

        /// <summary>
        /// Get SIC Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetSicIndexDataPointTextWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get SIC Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        List<HistoricalData> GetSicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get SIC Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        ApiResponse<List<HistoricalData>> GetSicIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Get a Stock Market Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>StockMarketIndex</returns>
        StockMarketIndex GetStockMarketIndexById (string identifier);

        /// <summary>
        /// Get a Stock Market Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of StockMarketIndex</returns>
        ApiResponse<StockMarketIndex> GetStockMarketIndexByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stock Market Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetStockMarketIndexDataPointNumber (string identifier, string item);

        /// <summary>
        /// Get Stock Market Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetStockMarketIndexDataPointNumberWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Stock Market Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        DataPointText GetStockMarketIndexDataPointText (string identifier, string item);

        /// <summary>
        /// Get Stock Market Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetStockMarketIndexDataPointTextWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Stock Market Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        List<HistoricalData> GetStockMarketIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get Stock Market Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        ApiResponse<List<HistoricalData>> GetStockMarketIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Search Economic Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;EconomicIndexSummary&gt;</returns>
        List<EconomicIndexSummary> SearchEconomicIndices (string query, string nextPage = null);

        /// <summary>
        /// Search Economic Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;EconomicIndexSummary&gt;</returns>
        ApiResponse<List<EconomicIndexSummary>> SearchEconomicIndicesWithHttpInfo (string query, string nextPage = null);
        /// <summary>
        /// Search SIC Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;SICIndex&gt;</returns>
        List<SICIndex> SearchSicIndices (string query, string nextPage = null);

        /// <summary>
        /// Search SIC Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;SICIndex&gt;</returns>
        ApiResponse<List<SICIndex>> SearchSicIndicesWithHttpInfo (string query, string nextPage = null);
        /// <summary>
        /// Search Stock Market Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StockMarketIndexSummary&gt;</returns>
        List<StockMarketIndexSummary> SearchStockMarketsIndices (string query, string nextPage = null);

        /// <summary>
        /// Search Stock Market Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StockMarketIndexSummary&gt;</returns>
        ApiResponse<List<StockMarketIndexSummary>> SearchStockMarketsIndicesWithHttpInfo (string query, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get ALl Economic Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;EconomicIndexSummary&gt;</returns>
        System.Threading.Tasks.Task<List<EconomicIndexSummary>> GetAllEconomicIndicesAsync (string nextPage = null);

        /// <summary>
        /// Get ALl Economic Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EconomicIndexSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EconomicIndexSummary>>> GetAllEconomicIndicesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get All SIC Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;SICIndex&gt;</returns>
        System.Threading.Tasks.Task<List<SICIndex>> GetAllSicIndicesAsync (string nextPage = null);

        /// <summary>
        /// Get All SIC Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SICIndex&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SICIndex>>> GetAllSicIndicesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get All Stock Market Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StockMarketIndexSummary&gt;</returns>
        System.Threading.Tasks.Task<List<StockMarketIndexSummary>> GetAllStockMarketIndicesAsync (string nextPage = null);

        /// <summary>
        /// Get All Stock Market Indices
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StockMarketIndexSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StockMarketIndexSummary>>> GetAllStockMarketIndicesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get an Economic Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of EconomicIndex</returns>
        System.Threading.Tasks.Task<EconomicIndex> GetEconomicIndexByIdAsync (string identifier);

        /// <summary>
        /// Get an Economic Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (EconomicIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<EconomicIndex>> GetEconomicIndexByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Economic Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetEconomicIndexDataPointNumberAsync (string identifier, string item);

        /// <summary>
        /// Get Economic Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetEconomicIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Economic Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetEconomicIndexDataPointTextAsync (string identifier, string item);

        /// <summary>
        /// Get Economic Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetEconomicIndexDataPointTextAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Economic Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        System.Threading.Tasks.Task<List<HistoricalData>> GetEconomicIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get Economic Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetEconomicIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Get an SIC Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of SICIndex</returns>
        System.Threading.Tasks.Task<SICIndex> GetSicIndexByIdAsync (string identifier);

        /// <summary>
        /// Get an SIC Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (SICIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<SICIndex>> GetSicIndexByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get SIC Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetSicIndexDataPointNumberAsync (string identifier, string item);

        /// <summary>
        /// Get SIC Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetSicIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get SIC Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetSicIndexDataPointTextAsync (string identifier, string item);

        /// <summary>
        /// Get SIC Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetSicIndexDataPointTextAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get SIC Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        System.Threading.Tasks.Task<List<HistoricalData>> GetSicIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get SIC Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetSicIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Get a Stock Market Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of StockMarketIndex</returns>
        System.Threading.Tasks.Task<StockMarketIndex> GetStockMarketIndexByIdAsync (string identifier);

        /// <summary>
        /// Get a Stock Market Index by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (StockMarketIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<StockMarketIndex>> GetStockMarketIndexByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stock Market Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetStockMarketIndexDataPointNumberAsync (string identifier, string item);

        /// <summary>
        /// Get Stock Market Index Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetStockMarketIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Stock Market Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetStockMarketIndexDataPointTextAsync (string identifier, string item);

        /// <summary>
        /// Get Stock Market Index Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetStockMarketIndexDataPointTextAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get Stock Market Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        System.Threading.Tasks.Task<List<HistoricalData>> GetStockMarketIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);

        /// <summary>
        /// Get Stock Market Index Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetStockMarketIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null);
        /// <summary>
        /// Search Economic Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;EconomicIndexSummary&gt;</returns>
        System.Threading.Tasks.Task<List<EconomicIndexSummary>> SearchEconomicIndicesAsync (string query, string nextPage = null);

        /// <summary>
        /// Search Economic Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EconomicIndexSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EconomicIndexSummary>>> SearchEconomicIndicesAsyncWithHttpInfo (string query, string nextPage = null);
        /// <summary>
        /// Search SIC Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;SICIndex&gt;</returns>
        System.Threading.Tasks.Task<List<SICIndex>> SearchSicIndicesAsync (string query, string nextPage = null);

        /// <summary>
        /// Search SIC Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SICIndex&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SICIndex>>> SearchSicIndicesAsyncWithHttpInfo (string query, string nextPage = null);
        /// <summary>
        /// Search Stock Market Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StockMarketIndexSummary&gt;</returns>
        System.Threading.Tasks.Task<List<StockMarketIndexSummary>> SearchStockMarketsIndicesAsync (string query, string nextPage = null);

        /// <summary>
        /// Search Stock Market Indices
        /// </summary>
        /// <remarks>
        /// Searches for indices using the text in &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StockMarketIndexSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StockMarketIndexSummary>>> SearchStockMarketsIndicesAsyncWithHttpInfo (string query, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IndexApi : IIndexApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IndexApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IndexApi(Configuration configuration = null)
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
        /// Get ALl Economic Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;EconomicIndexSummary&gt;</returns>
        public List<EconomicIndexSummary> GetAllEconomicIndices (string nextPage = null)
        {
             ApiResponse<List<EconomicIndexSummary>> localVarResponse = GetAllEconomicIndicesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get ALl Economic Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;EconomicIndexSummary&gt;</returns>
        public ApiResponse< List<EconomicIndexSummary> > GetAllEconomicIndicesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/economic";
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
                Exception exception = ExceptionFactory("GetAllEconomicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EconomicIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EconomicIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EconomicIndexSummary>)));
        }

        /// <summary>
        /// Get ALl Economic Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;EconomicIndexSummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<EconomicIndexSummary>> GetAllEconomicIndicesAsync (string nextPage = null)
        {
             ApiResponse<List<EconomicIndexSummary>> localVarResponse = await GetAllEconomicIndicesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get ALl Economic Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EconomicIndexSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<EconomicIndexSummary>>> GetAllEconomicIndicesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/economic";
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
                Exception exception = ExceptionFactory("GetAllEconomicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EconomicIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EconomicIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EconomicIndexSummary>)));
        }

        /// <summary>
        /// Get All SIC Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;SICIndex&gt;</returns>
        public List<SICIndex> GetAllSicIndices (string nextPage = null)
        {
             ApiResponse<List<SICIndex>> localVarResponse = GetAllSicIndicesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All SIC Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;SICIndex&gt;</returns>
        public ApiResponse< List<SICIndex> > GetAllSicIndicesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/sic";
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
                Exception exception = ExceptionFactory("GetAllSicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SICIndex>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SICIndex>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SICIndex>)));
        }

        /// <summary>
        /// Get All SIC Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;SICIndex&gt;</returns>
        public async System.Threading.Tasks.Task<List<SICIndex>> GetAllSicIndicesAsync (string nextPage = null)
        {
             ApiResponse<List<SICIndex>> localVarResponse = await GetAllSicIndicesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All SIC Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SICIndex&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SICIndex>>> GetAllSicIndicesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/sic";
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
                Exception exception = ExceptionFactory("GetAllSicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SICIndex>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SICIndex>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SICIndex>)));
        }

        /// <summary>
        /// Get All Stock Market Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StockMarketIndexSummary&gt;</returns>
        public List<StockMarketIndexSummary> GetAllStockMarketIndices (string nextPage = null)
        {
             ApiResponse<List<StockMarketIndexSummary>> localVarResponse = GetAllStockMarketIndicesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Stock Market Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StockMarketIndexSummary&gt;</returns>
        public ApiResponse< List<StockMarketIndexSummary> > GetAllStockMarketIndicesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/stock_market";
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
                Exception exception = ExceptionFactory("GetAllStockMarketIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StockMarketIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StockMarketIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StockMarketIndexSummary>)));
        }

        /// <summary>
        /// Get All Stock Market Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StockMarketIndexSummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<StockMarketIndexSummary>> GetAllStockMarketIndicesAsync (string nextPage = null)
        {
             ApiResponse<List<StockMarketIndexSummary>> localVarResponse = await GetAllStockMarketIndicesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Stock Market Indices 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StockMarketIndexSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StockMarketIndexSummary>>> GetAllStockMarketIndicesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/indices/stock_market";
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
                Exception exception = ExceptionFactory("GetAllStockMarketIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StockMarketIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StockMarketIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StockMarketIndexSummary>)));
        }

        /// <summary>
        /// Get an Economic Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>EconomicIndex</returns>
        public EconomicIndex GetEconomicIndexById (string identifier)
        {
             ApiResponse<EconomicIndex> localVarResponse = GetEconomicIndexByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Economic Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of EconomicIndex</returns>
        public ApiResponse< EconomicIndex > GetEconomicIndexByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexById");

            var localVarPath = "/indices/economic/{identifier}";
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
                Exception exception = ExceptionFactory("GetEconomicIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EconomicIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EconomicIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EconomicIndex)));
        }

        /// <summary>
        /// Get an Economic Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of EconomicIndex</returns>
        public async System.Threading.Tasks.Task<EconomicIndex> GetEconomicIndexByIdAsync (string identifier)
        {
             ApiResponse<EconomicIndex> localVarResponse = await GetEconomicIndexByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Economic Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (EconomicIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EconomicIndex>> GetEconomicIndexByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexById");

            var localVarPath = "/indices/economic/{identifier}";
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
                Exception exception = ExceptionFactory("GetEconomicIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EconomicIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EconomicIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EconomicIndex)));
        }

        /// <summary>
        /// Get Economic Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetEconomicIndexDataPointNumber (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetEconomicIndexDataPointNumberWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Economic Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetEconomicIndexDataPointNumberWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexDataPointNumber");

            var localVarPath = "/indices/economic/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetEconomicIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Economic Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetEconomicIndexDataPointNumberAsync (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetEconomicIndexDataPointNumberAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Economic Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetEconomicIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexDataPointNumber");

            var localVarPath = "/indices/economic/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetEconomicIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Economic Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetEconomicIndexDataPointText (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = GetEconomicIndexDataPointTextWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Economic Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetEconomicIndexDataPointTextWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexDataPointText");

            var localVarPath = "/indices/economic/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetEconomicIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Economic Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetEconomicIndexDataPointTextAsync (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = await GetEconomicIndexDataPointTextAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Economic Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetEconomicIndexDataPointTextAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexDataPointText");

            var localVarPath = "/indices/economic/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetEconomicIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Economic Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        public List<HistoricalData> GetEconomicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = GetEconomicIndexHistoricalDataWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Economic Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        public ApiResponse< List<HistoricalData> > GetEconomicIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexHistoricalData");

            var localVarPath = "/indices/economic/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetEconomicIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get Economic Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        public async System.Threading.Tasks.Task<List<HistoricalData>> GetEconomicIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = await GetEconomicIndexHistoricalDataAsyncWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Economic Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Economic Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetEconomicIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetEconomicIndexHistoricalData");

            var localVarPath = "/indices/economic/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetEconomicIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get an SIC Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>SICIndex</returns>
        public SICIndex GetSicIndexById (string identifier)
        {
             ApiResponse<SICIndex> localVarResponse = GetSicIndexByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an SIC Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of SICIndex</returns>
        public ApiResponse< SICIndex > GetSicIndexByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexById");

            var localVarPath = "/indices/sic/{identifier}";
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
                Exception exception = ExceptionFactory("GetSicIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SICIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SICIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SICIndex)));
        }

        /// <summary>
        /// Get an SIC Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of SICIndex</returns>
        public async System.Threading.Tasks.Task<SICIndex> GetSicIndexByIdAsync (string identifier)
        {
             ApiResponse<SICIndex> localVarResponse = await GetSicIndexByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an SIC Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (SICIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SICIndex>> GetSicIndexByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexById");

            var localVarPath = "/indices/sic/{identifier}";
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
                Exception exception = ExceptionFactory("GetSicIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SICIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SICIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SICIndex)));
        }

        /// <summary>
        /// Get SIC Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetSicIndexDataPointNumber (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetSicIndexDataPointNumberWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get SIC Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetSicIndexDataPointNumberWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexDataPointNumber");

            var localVarPath = "/indices/sic/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetSicIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get SIC Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetSicIndexDataPointNumberAsync (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetSicIndexDataPointNumberAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get SIC Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetSicIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexDataPointNumber");

            var localVarPath = "/indices/sic/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetSicIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get SIC Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetSicIndexDataPointText (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = GetSicIndexDataPointTextWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get SIC Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetSicIndexDataPointTextWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexDataPointText");

            var localVarPath = "/indices/sic/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetSicIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get SIC Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetSicIndexDataPointTextAsync (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = await GetSicIndexDataPointTextAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get SIC Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetSicIndexDataPointTextAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexDataPointText");

            var localVarPath = "/indices/sic/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetSicIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get SIC Index Historical Data Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        public List<HistoricalData> GetSicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = GetSicIndexHistoricalDataWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get SIC Index Historical Data Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        public ApiResponse< List<HistoricalData> > GetSicIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexHistoricalData");

            var localVarPath = "/indices/sic/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetSicIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get SIC Index Historical Data Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        public async System.Threading.Tasks.Task<List<HistoricalData>> GetSicIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = await GetSicIndexHistoricalDataAsyncWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get SIC Index Historical Data Returns historical values for the given &#x60;item&#x60; and the SIC Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetSicIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetSicIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetSicIndexHistoricalData");

            var localVarPath = "/indices/sic/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetSicIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get a Stock Market Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>StockMarketIndex</returns>
        public StockMarketIndex GetStockMarketIndexById (string identifier)
        {
             ApiResponse<StockMarketIndex> localVarResponse = GetStockMarketIndexByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Stock Market Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>ApiResponse of StockMarketIndex</returns>
        public ApiResponse< StockMarketIndex > GetStockMarketIndexByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexById");

            var localVarPath = "/indices/stock_market/{identifier}";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockMarketIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StockMarketIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockMarketIndex)));
        }

        /// <summary>
        /// Get a Stock Market Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of StockMarketIndex</returns>
        public async System.Threading.Tasks.Task<StockMarketIndex> GetStockMarketIndexByIdAsync (string identifier)
        {
             ApiResponse<StockMarketIndex> localVarResponse = await GetStockMarketIndexByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Stock Market Index by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (StockMarketIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StockMarketIndex>> GetStockMarketIndexByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexById");

            var localVarPath = "/indices/stock_market/{identifier}";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockMarketIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StockMarketIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockMarketIndex)));
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetStockMarketIndexDataPointNumber (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetStockMarketIndexDataPointNumberWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetStockMarketIndexDataPointNumberWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexDataPointNumber");

            var localVarPath = "/indices/stock_market/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetStockMarketIndexDataPointNumberAsync (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetStockMarketIndexDataPointNumberAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Market Index Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetStockMarketIndexDataPointNumberAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexDataPointNumber");

            var localVarPath = "/indices/stock_market/{identifier}/data_point/{item}/number";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetStockMarketIndexDataPointText (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = GetStockMarketIndexDataPointTextWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetStockMarketIndexDataPointTextWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexDataPointText");

            var localVarPath = "/indices/stock_market/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Stock Market Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetStockMarketIndexDataPointTextAsync (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = await GetStockMarketIndexDataPointTextAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Market Index Data Point (Text) Returns a text value for the given &#x60;item&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetStockMarketIndexDataPointTextAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexDataPointText");

            var localVarPath = "/indices/stock_market/{identifier}/data_point/{item}/text";
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
                Exception exception = ExceptionFactory("GetStockMarketIndexDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Stock Market Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        public List<HistoricalData> GetStockMarketIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = GetStockMarketIndexHistoricalDataWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Market Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        public ApiResponse< List<HistoricalData> > GetStockMarketIndexHistoricalDataWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexHistoricalData");

            var localVarPath = "/indices/stock_market/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetStockMarketIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get Stock Market Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        public async System.Threading.Tasks.Task<List<HistoricalData>> GetStockMarketIndexHistoricalDataAsync (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = await GetStockMarketIndexHistoricalDataAsyncWithHttpInfo(identifier, item, type, startDate, endDate, sortOrder, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Market Index Historical Data Returns historical values for the given &#x60;item&#x60; and the Stock Market Index with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize"> (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetStockMarketIndexHistoricalDataAsyncWithHttpInfo (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexHistoricalData");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling IndexApi->GetStockMarketIndexHistoricalData");

            var localVarPath = "/indices/stock_market/{identifier}/historical_data/{item}";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetStockMarketIndexHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;EconomicIndexSummary&gt;</returns>
        public List<EconomicIndexSummary> SearchEconomicIndices (string query, string nextPage = null)
        {
             ApiResponse<List<EconomicIndexSummary>> localVarResponse = SearchEconomicIndicesWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;EconomicIndexSummary&gt;</returns>
        public ApiResponse< List<EconomicIndexSummary> > SearchEconomicIndicesWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchEconomicIndices");

            var localVarPath = "/indices/economic/search";
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
                Exception exception = ExceptionFactory("SearchEconomicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EconomicIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EconomicIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EconomicIndexSummary>)));
        }

        /// <summary>
        /// Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;EconomicIndexSummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<EconomicIndexSummary>> SearchEconomicIndicesAsync (string query, string nextPage = null)
        {
             ApiResponse<List<EconomicIndexSummary>> localVarResponse = await SearchEconomicIndicesAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EconomicIndexSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<EconomicIndexSummary>>> SearchEconomicIndicesAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchEconomicIndices");

            var localVarPath = "/indices/economic/search";
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
                Exception exception = ExceptionFactory("SearchEconomicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<EconomicIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EconomicIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EconomicIndexSummary>)));
        }

        /// <summary>
        /// Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;SICIndex&gt;</returns>
        public List<SICIndex> SearchSicIndices (string query, string nextPage = null)
        {
             ApiResponse<List<SICIndex>> localVarResponse = SearchSicIndicesWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;SICIndex&gt;</returns>
        public ApiResponse< List<SICIndex> > SearchSicIndicesWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchSicIndices");

            var localVarPath = "/indices/sic/search";
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
                Exception exception = ExceptionFactory("SearchSicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SICIndex>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SICIndex>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SICIndex>)));
        }

        /// <summary>
        /// Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;SICIndex&gt;</returns>
        public async System.Threading.Tasks.Task<List<SICIndex>> SearchSicIndicesAsync (string query, string nextPage = null)
        {
             ApiResponse<List<SICIndex>> localVarResponse = await SearchSicIndicesAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;SICIndex&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SICIndex>>> SearchSicIndicesAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchSicIndices");

            var localVarPath = "/indices/sic/search";
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
                Exception exception = ExceptionFactory("SearchSicIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SICIndex>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SICIndex>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SICIndex>)));
        }

        /// <summary>
        /// Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StockMarketIndexSummary&gt;</returns>
        public List<StockMarketIndexSummary> SearchStockMarketsIndices (string query, string nextPage = null)
        {
             ApiResponse<List<StockMarketIndexSummary>> localVarResponse = SearchStockMarketsIndicesWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StockMarketIndexSummary&gt;</returns>
        public ApiResponse< List<StockMarketIndexSummary> > SearchStockMarketsIndicesWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchStockMarketsIndices");

            var localVarPath = "/indices/stock_market/search";
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
                Exception exception = ExceptionFactory("SearchStockMarketsIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StockMarketIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StockMarketIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StockMarketIndexSummary>)));
        }

        /// <summary>
        /// Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StockMarketIndexSummary&gt;</returns>
        public async System.Threading.Tasks.Task<List<StockMarketIndexSummary>> SearchStockMarketsIndicesAsync (string query, string nextPage = null)
        {
             ApiResponse<List<StockMarketIndexSummary>> localVarResponse = await SearchStockMarketsIndicesAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StockMarketIndexSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StockMarketIndexSummary>>> SearchStockMarketsIndicesAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling IndexApi->SearchStockMarketsIndices");

            var localVarPath = "/indices/stock_market/search";
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
                Exception exception = ExceptionFactory("SearchStockMarketsIndices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StockMarketIndexSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StockMarketIndexSummary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StockMarketIndexSummary>)));
        }

    }
}
