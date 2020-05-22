namespace BMESRestApi.Models.Cart
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Shared;

    public class Cart:BaseObject
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        [Key]
        public int CartID { get; set; }
        public string UniqueCartId { get; set; }
        public CartStatus CartStatus { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
