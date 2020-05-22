using System;
using System.Collections.Generic;

namespace BMESRestApi.Messages.DataTransferObjects.Cart
{
    public class CartDTO
    {
        public CartDTO()
        {
            CartItemsDTO = new List<CartItemDTO>();
        }

        public int CartID { get; set; }
        public string UniqueCartId { get; set; }
        public int CartStatus { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<CartItemDTO> CartItemsDTO { get; set; }
    }
}
