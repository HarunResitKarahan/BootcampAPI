using Microsoft.EntityFrameworkCore;

namespace BootcampAPI.Models
{
    public class FeaturedProduct
    {
        public int FeaturedProductId { get; set; }
        public int ProductId { get; set; }
    }
}
