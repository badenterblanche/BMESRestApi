namespace BMESRestApi.Models.Cart
{
    using Shared;
    using Product;
    using System.ComponentModel.DataAnnotations;

    public class CartItem : BaseObject
    {
        [Key]
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public Cart Cart { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
