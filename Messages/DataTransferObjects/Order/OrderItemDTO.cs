using BMESRestApi.Messages.DataTransferObjects.Product;
using System.ComponentModel.DataAnnotations;

namespace BMESRestApi.Messages.DataTransferObjects.Order
{
    public class OrderItemDTO
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }
    }
}
