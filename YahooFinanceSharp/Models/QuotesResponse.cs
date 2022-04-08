namespace YahooFinanceSharp.Models
{

    public class QuotesResponse
    {
        public QuoteResponse QuoteResponse { get; set; }
    }

    public class QuoteResponse
    {
        public List<Quote> Result { get; set; }
        public string Error { get; set; }
    }

    public class Quote
    {
        public string Language { get; set; }
        public string Region { get; set; }
        public string QuoteType { get; set; }
        public string TypeDisp { get; set; }
        public string QuoteSourceName { get; set; }
        public bool? Triggerable { get; set; }
        public string CustomPriceAlertConfidence { get; set; }
        public string Currency { get; set; }
        public string MarketState { get; set; }
        public string FiftyTwoWeekRange { get; set; }
        public double? FiftyTwoWeekHighChange { get; set; }
        public double? FiftyTwoWeekHighChangePercent { get; set; }
        public double? FiftyTwoWeekLow { get; set; }
        public double? FiftyTwoWeekHigh { get; set; }
        public long? DividendDate { get; set; }
        public long? EarningsTimestamp { get; set; }
        public long? EarningsTimestampStart { get; set; }
        public long? EarningsTimestampEnd { get; set; }
        public double? TrailingAnnualDividendRate { get; set; }
        public double? TrailingPe { get; set; }
        public double? TrailingAnnualDividendYield { get; set; }
        public double? EpsTrailingTwelveMonths { get; set; }
        public double? EpsForward { get; set; }
        public double? EpsCurrentYear { get; set; }
        public double? PriceEpsCurrentYear { get; set; }
        public long? SharesOutstanding { get; set; }
        public double? BookValue { get; set; }
        public double? FiftyDayAverage { get; set; }
        public double? FiftyDayAverageChange { get; set; }
        public double? FiftyDayAverageChangePercent { get; set; }
        public double? TwoHundredDayAverage { get; set; }
        public double? TwoHundredDayAverageChange { get; set; }
        public double? TwoHundredDayAverageChangePercent { get; set; }
        public long? MarketCap { get; set; }
        public double? ForwardPe { get; set; }
        public double? PriceToBook { get; set; }
        public long? SourceInterval { get; set; }
        public long? ExchangeDataDelayedBy { get; set; }
        public double? PageViewGrowthWeekly { get; set; }
        public string AverageAnalystRating { get; set; }
        public long? FirstTradeDateMilliseconds { get; set; }
        public long? PriceHint { get; set; }
        public double? PreMarketChange { get; set; }
        public double? PreMarketChangePercent { get; set; }
        public long? PreMarketTime { get; set; }
        public double? PreMarketPrice { get; set; }
        public double? RegularMarketChange { get; set; }
        public double? RegularMarketChangePercent { get; set; }
        public long? RegularMarketTime { get; set; }
        public double? RegularMarketPrice { get; set; }
        public double? RegularMarketDayHigh { get; set; }
        public string RegularMarketDayRange { get; set; }
        public double? RegularMarketDayLow { get; set; }
        public long? RegularMarketVolume { get; set; }
        public double? RegularMarketPreviousClose { get; set; }
        public double? Bid { get; set; }
        public double? Ask { get; set; }
        public long? BidSize { get; set; }
        public long? AskSize { get; set; }
        public string FullExchangeName { get; set; }
        public string FinancialCurrency { get; set; }
        public double? RegularMarketOpen { get; set; }
        public long? AverageDailyVolume3Month { get; set; }
        public long? AverageDailyVolume10Day { get; set; }
        public double? FiftyTwoWeekLowChange { get; set; }
        public double? FiftyTwoWeekLowChangePercent { get; set; }
        public string Exchange { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string MessageBoardId { get; set; }
        public string ExchangeTimezoneName { get; set; }
        public string ExchangeTimezoneShortName { get; set; }
        public long? GmtOffSetMilliseconds { get; set; }
        public string Market { get; set; }
        public bool? EsgPopulated { get; set; }
        public bool? Tradeable { get; set; }
        public string DisplayName { get; set; }
        public string Symbol { get; set; }
        public long? CirculatingSupply { get; set; }
        public string LastMarket { get; set; }
        public long? Volume24Hr { get; set; }
        public long? VolumeAllCurrencies { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public long? StartDate { get; set; }
        public Uri CoinImageUrl { get; set; }
    }
}
