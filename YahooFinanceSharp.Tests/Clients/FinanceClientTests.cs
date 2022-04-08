using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Refit;
using RichardSzalay.MockHttp;
using Xunit;
using YahooFinanceSharp.Clients;
using YahooFinanceSharp.Models;

namespace YahooFinanceSharp.Tests.Clients;

public class FinanceClientTests
{
    [Fact]
    public async Task GetQuotes_SingleSymbol_ReturnsSingleQuote()
    {
        const string ticker = "AAPL";

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.Expect(HttpMethod.Get, "https://yfapi.net/v6/finance/quote")
            .WithExactQueryString(new Dictionary<string, string>
            {
                { "symbols", ticker },
                { "region", "US" },
                { "lang", "en" }
            })
            .Respond("application/json", new QuotesResponse()
            {
                QuoteResponse = new QuoteResponse()
                {
                    Result = new List<Quote>()
                    {
                        new()
                        {
                            Symbol = "AAPL"
                        }
                    }
                }
            }.SerializeToJson());

        var settings = new RefitSettings
        {
            HttpMessageHandlerFactory = () => mockHttp
        };
        var fixture = RestService.For<IFinanceClient>("https://yfapi.net", settings);

        var response = await fixture.GetQuote(ticker);

        response.QuoteResponse.Result.Should().HaveCount(1);
        var quote = response.QuoteResponse.Result.First();
        quote.Symbol.Should().Be("AAPL");
        mockHttp.VerifyNoOutstandingExpectation();
    }

    [Fact]
    public async Task GetQuotes_ThreeSymbols_ReturnsThreeQuotes()
    {
        const string tickers = "AAPL,MSFT,JPM";

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.Expect(HttpMethod.Get, "https://yfapi.net/v6/finance/quote")
            .WithExactQueryString(new Dictionary<string, string>
            {
                { "symbols", tickers },
                { "region", "US" },
                { "lang", "en" }
            })
            .Respond("application/json", new QuotesResponse()
            {
                QuoteResponse = new QuoteResponse()
                {
                    Result = new List<Quote>()
                    {
                        new()
                        {
                            Symbol = "AAPL"
                        },
                        new()
                        {
                            Symbol = "MSFT"
                        },
                        new()
                        {
                            Symbol = "JPM"
                        }
                    }
                }
            }.SerializeToJson());

        var settings = new RefitSettings
        {
            HttpMessageHandlerFactory = () => mockHttp
        };
        var fixture = RestService.For<IFinanceClient>("https://yfapi.net", settings);

        var response = await fixture.GetQuote(tickers);

        response.QuoteResponse.Result.Should().HaveCount(3);
        mockHttp.VerifyNoOutstandingExpectation();
    }
    
    [Fact]
    public async Task Get_ThreeSymbols_ReturnsThreeQuotes()
    {
        const string tickers = "AAPL,MSFT,JPM";

        var mockHttp = new MockHttpMessageHandler();
        mockHttp.Expect(HttpMethod.Get, "https://yfapi.net/v6/finance/quote")
            .WithExactQueryString(new Dictionary<string, string>
            {
                { "symbols", tickers },
                { "region", "US" },
                { "lang", "en" }
            })
            .Respond("application/json", new QuotesResponse()
            {
                QuoteResponse = new QuoteResponse()
                {
                    Result = new List<Quote>()
                    {
                        new()
                        {
                            Symbol = "AAPL"
                        },
                        new()
                        {
                            Symbol = "MSFT"
                        },
                        new()
                        {
                            Symbol = "JPM"
                        }
                    }
                }
            }.SerializeToJson());

        var settings = new RefitSettings
        {
            HttpMessageHandlerFactory = () => mockHttp
        };
        var fixture = RestService.For<IFinanceClient>("https://yfapi.net", settings);

        var response = await fixture.GetQuote(tickers);

        response.QuoteResponse.Result.Should().HaveCount(3);
        mockHttp.VerifyNoOutstandingExpectation();
    }

    [Fact]
    public async Task Test()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://yfapi.net");
        httpClient.DefaultRequestHeaders.Add("x-api-key", "7tv248A54PaXNSnzOiJW19q4D5o5dge2YSl5Jhr3");
        
        var finance = RestService.For<IFinanceClient>(httpClient);
        var fb = await finance.GetAutocomplete("baba");
    }
}