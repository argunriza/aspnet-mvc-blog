namespace MvcEticaret.Models
{
    public class ProductItemModel
    {
        public string Title { get; set; }
        public int StarCount { get; set; }
        public string OldPrice { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}
