# Intrinio.Api.IndexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEconomicIndices**](IndexApi.md#getalleconomicindices) | **GET** /indices/economic | Get ALl Economic Indices
[**GetAllSicIndices**](IndexApi.md#getallsicindices) | **GET** /indices/sic | Get All SIC Indices
[**GetAllStockMarketIndices**](IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | Get All Stock Market Indices
[**GetEconomicIndexById**](IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Get an Economic Index by ID
[**GetEconomicIndexDataPointNumber**](IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{item}/number | Get Economic Index Data Point (Number)
[**GetEconomicIndexDataPointText**](IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{item}/text | Get Economic Index Data Point (Text)
[**GetEconomicIndexHistoricalData**](IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{item} | Get Economic Index Historical Data
[**GetSicIndexById**](IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Get an SIC Index by ID
[**GetSicIndexDataPointNumber**](IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{item}/number | Get SIC Index Data Point (Number)
[**GetSicIndexDataPointText**](IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{item}/text | Get SIC Index Data Point (Text)
[**GetSicIndexHistoricalData**](IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{item} | Get SIC Index Historical Data
[**GetStockMarketIndexById**](IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Get a Stock Market Index by ID
[**GetStockMarketIndexDataPointNumber**](IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{item}/number | Get Stock Market Index Data Point (Number)
[**GetStockMarketIndexDataPointText**](IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{item}/text | Get Stock Market Index Data Point (Text)
[**GetStockMarketIndexHistoricalData**](IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{item} | Get Stock Market Index Historical Data
[**SearchEconomicIndices**](IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
[**SearchSicIndices**](IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
[**SearchStockMarketsIndices**](IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices


<a name="getalleconomicindices"></a>
# **GetAllEconomicIndices**
> List<EconomicIndexSummary> GetAllEconomicIndices (string nextPage = null)

Get ALl Economic Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllEconomicIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;EconomicIndexSummary&gt; result = indexApi.GetAllEconomicIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllEconomicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<EconomicIndexSummary>**](EconomicIndexSummary.md)

<a name="getallsicindices"></a>
# **GetAllSicIndices**
> List<SICIndex> GetAllSicIndices (string nextPage = null)

Get All SIC Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllSicIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;SICIndex&gt; result = indexApi.GetAllSicIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllSicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<SICIndex>**](SICIndex.md)

<a name="getallstockmarketindices"></a>
# **GetAllStockMarketIndices**
> List<StockMarketIndexSummary> GetAllStockMarketIndices (string nextPage = null)

Get All Stock Market Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllStockMarketIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StockMarketIndexSummary&gt; result = indexApi.GetAllStockMarketIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllStockMarketIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<StockMarketIndexSummary>**](StockMarketIndexSummary.md)

<a name="geteconomicindexbyid"></a>
# **GetEconomicIndexById**
> EconomicIndex GetEconomicIndexById (string identifier)

Get an Economic Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetEconomicIndexByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                EconomicIndex result = indexApi.GetEconomicIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**EconomicIndex**](EconomicIndex.md)

<a name="geteconomicindexdatapointnumber"></a>
# **GetEconomicIndexDataPointNumber**
> DataPointNumber GetEconomicIndexDataPointNumber (string identifier, string item)

Get Economic Index Data Point (Number)

Returns a numeric value for the given `item` for the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetEconomicIndexDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointNumber result = indexApi.GetEconomicIndexDataPointNumber(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="geteconomicindexdatapointtext"></a>
# **GetEconomicIndexDataPointText**
> DataPointText GetEconomicIndexDataPointText (string identifier, string item)

Get Economic Index Data Point (Text)

Returns a text value for the given `item` for the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetEconomicIndexDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointText result = indexApi.GetEconomicIndexDataPointText(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="geteconomicindexhistoricaldata"></a>
# **GetEconomicIndexHistoricalData**
> List<HistoricalData> GetEconomicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)

Get Economic Index Historical Data

Returns historical values for the given `item` and the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetEconomicIndexHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 8.14;  // decimal? |  (optional)  (default to 100)

            try
            {
                List&lt;HistoricalData&gt; result = indexApi.GetEconomicIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **decimal?**|  | [optional] [default to 100]

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="getsicindexbyid"></a>
# **GetSicIndexById**
> SICIndex GetSicIndexById (string identifier)

Get an SIC Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSicIndexByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                SICIndex result = indexApi.GetSicIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**SICIndex**](SICIndex.md)

<a name="getsicindexdatapointnumber"></a>
# **GetSicIndexDataPointNumber**
> DataPointNumber GetSicIndexDataPointNumber (string identifier, string item)

Get SIC Index Data Point (Number)

Returns a numeric value for the given `item` for the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSicIndexDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointNumber result = indexApi.GetSicIndexDataPointNumber(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getsicindexdatapointtext"></a>
# **GetSicIndexDataPointText**
> DataPointText GetSicIndexDataPointText (string identifier, string item)

Get SIC Index Data Point (Text)

Returns a text value for the given `item` for the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSicIndexDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointText result = indexApi.GetSicIndexDataPointText(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="getsicindexhistoricaldata"></a>
# **GetSicIndexHistoricalData**
> List<HistoricalData> GetSicIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)

Get SIC Index Historical Data

Returns historical values for the given `item` and the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSicIndexHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 8.14;  // decimal? |  (optional)  (default to 100)

            try
            {
                List&lt;HistoricalData&gt; result = indexApi.GetSicIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **decimal?**|  | [optional] [default to 100]

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="getstockmarketindexbyid"></a>
# **GetStockMarketIndexById**
> StockMarketIndex GetStockMarketIndexById (string identifier)

Get a Stock Market Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockMarketIndexByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                StockMarketIndex result = indexApi.GetStockMarketIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**StockMarketIndex**](StockMarketIndex.md)

<a name="getstockmarketindexdatapointnumber"></a>
# **GetStockMarketIndexDataPointNumber**
> DataPointNumber GetStockMarketIndexDataPointNumber (string identifier, string item)

Get Stock Market Index Data Point (Number)

Returns a numeric value for the given `item` for the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockMarketIndexDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointNumber result = indexApi.GetStockMarketIndexDataPointNumber(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getstockmarketindexdatapointtext"></a>
# **GetStockMarketIndexDataPointText**
> DataPointText GetStockMarketIndexDataPointText (string identifier, string item)

Get Stock Market Index Data Point (Text)

Returns a text value for the given `item` for the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockMarketIndexDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointText result = indexApi.GetStockMarketIndexDataPointText(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="getstockmarketindexhistoricaldata"></a>
# **GetStockMarketIndexHistoricalData**
> List<HistoricalData> GetStockMarketIndexHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null)

Get Stock Market Index Historical Data

Returns historical values for the given `item` and the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockMarketIndexHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = identifier_example;  // string | An Index Identifier (symbol, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 8.14;  // decimal? |  (optional)  (default to 100)

            try
            {
                List&lt;HistoricalData&gt; result = indexApi.GetStockMarketIndexHistoricalData(identifier, item, type, startDate, endDate, sortOrder, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **decimal?**|  | [optional] [default to 100]

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="searcheconomicindices"></a>
# **SearchEconomicIndices**
> List<EconomicIndexSummary> SearchEconomicIndices (string query, string nextPage = null)

Search Economic Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchEconomicIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = query_example;  // string | Search query
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;EconomicIndexSummary&gt; result = indexApi.SearchEconomicIndices(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchEconomicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<EconomicIndexSummary>**](EconomicIndexSummary.md)

<a name="searchsicindices"></a>
# **SearchSicIndices**
> List<SICIndex> SearchSicIndices (string query, string nextPage = null)

Search SIC Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchSicIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = query_example;  // string | Search query
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;SICIndex&gt; result = indexApi.SearchSicIndices(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchSicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<SICIndex>**](SICIndex.md)

<a name="searchstockmarketsindices"></a>
# **SearchStockMarketsIndices**
> List<StockMarketIndexSummary> SearchStockMarketsIndices (string query, string nextPage = null)

Search Stock Market Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchStockMarketsIndicesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = query_example;  // string | Search query
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StockMarketIndexSummary&gt; result = indexApi.SearchStockMarketsIndices(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchStockMarketsIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<StockMarketIndexSummary>**](StockMarketIndexSummary.md)

