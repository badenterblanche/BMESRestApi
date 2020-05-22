namespace BMESRestApi.Messages.DataTransferObjects.Cart
{
    using Product;
    public class CartItemDTO
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }
    }
}
