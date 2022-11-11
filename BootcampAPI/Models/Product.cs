namespace BootcampAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public decimal ProductPrice { get; set; }
        public string PictureUri { get; set; }

        public int SubCategoryId { get; set; }
        //public SubCategory SubCategory { get; set; }
    }
}
