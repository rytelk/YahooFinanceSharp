namespace YahooFinanceSharp.Models
{

    public class AutocompleteResponse
    {
        public ResultSet ResultSet { get; set; }
    }

    public class ResultSet
    {
        public string Query { get; set; }
        public List<Result> Result { get; set; }
    }

    public class Result
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Exch { get; set; }
        public string Type { get; set; }
        public string ExchDisp { get; set; }
        public string TypeDisp { get; set; }
    }
}