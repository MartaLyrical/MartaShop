namespace MartaShop.Core.Models
{
    public class BasketItem : BaseEntity
    {
        public string BasketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}