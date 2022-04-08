using Refit;
using YahooFinanceSharp.Models;

namespace YahooFinanceSharp.Clients;

public interface IFinanceClient
{
    [Get("/v6/finance/quote")]
    public Task<QuotesResponse> GetQuote(string symbols, string region = "US", string lang = "en");
    
    [Get("/v6/finance/autocomplete")]
    public Task<AutocompleteResponse> GetAutocomplete(string query, string region = "US", string lang = "en");
}