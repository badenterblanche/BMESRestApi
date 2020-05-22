namespace BMESRestApi.Models.Order
{
    using Shared;
    using Product;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderItem: BaseObject
    {
        [Key]
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [ForeignKey("OrderItemProductFK")]
        public long ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
