namespace ZamApi.Models
// name, image, original price, sale price and a clickable link to the sale
//https://www.cheapshark.com/api/1.0/deals
//https://apidocs.cheapshark.com/
{
    public class GameDeal
    {
        public string title { get; set; }
        public string gameID { get; set; }
        public string thumb { get; set; }
        
        public string dealID { get; set; }

        public string salePrice { get; set; }
        public string normalPrice { get; set; }

        public string savings { get; set; }
        public string metacriticScore { get; set; }
        public string steamRatingPercent { get; set; }
        public string dealRating { get; set; }

    }
}