

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
    public interface IDataPointApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetDataPointNumber (string identifier, string item);

        /// <summary>
        /// Get a Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetDataPointNumberWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get a Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        DataPointText GetDataPointText (string identifier, string item);

        /// <summary>
        /// Get a Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetDataPointTextWithHttpInfo (string identifier, string item);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetDataPointNumberAsync (string identifier, string item);

        /// <summary>
        /// Get a Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetDataPointNumberAsyncWithHttpInfo (string identifier, string item);
        /// <summary>
        /// Get a Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetDataPointTextAsync (string identifier, string item);

        /// <summary>
        /// Get a Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetDataPointTextAsyncWithHttpInfo (string identifier, string item);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataPointApi : IDataPointApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataPointApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataPointApi(Configuration configuration = null)
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
        /// Get a Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetDataPointNumber (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetDataPointNumberWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetDataPointNumberWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling DataPointApi->GetDataPointNumber");

            var localVarPath = "/data_point/{identifier}/{item}/number";
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
                Exception exception = ExceptionFactory("GetDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get a Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetDataPointNumberAsync (string identifier, string item)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetDataPointNumberAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Data Point (Number) Returns a numeric value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetDataPointNumberAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointNumber");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling DataPointApi->GetDataPointNumber");

            var localVarPath = "/data_point/{identifier}/{item}/number";
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
                Exception exception = ExceptionFactory("GetDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get a Data Point (Text) Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetDataPointText (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = GetDataPointTextWithHttpInfo(identifier, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Data Point (Text) Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetDataPointTextWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling DataPointApi->GetDataPointText");

            var localVarPath = "/data_point/{identifier}/{item}/text";
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
                Exception exception = ExceptionFactory("GetDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get a Data Point (Text) Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetDataPointTextAsync (string identifier, string item)
        {
             ApiResponse<DataPointText> localVarResponse = await GetDataPointTextAsyncWithHttpInfo(identifier, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Data Point (Text) Returns a text value for the given &#x60;item&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="item">An Intrinio data tag or other item</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetDataPointTextAsyncWithHttpInfo (string identifier, string item)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointText");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling DataPointApi->GetDataPointText");

            var localVarPath = "/data_point/{identifier}/{item}/text";
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
                Exception exception = ExceptionFactory("GetDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

    }
}
