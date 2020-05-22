using System.Collections.Generic;
using BMESRestApi.Messages.DataTransferObjects.Address;
using BMESRestApi.Messages.DataTransferObjects.Cart;
using BMESRestApi.Messages.DataTransferObjects.Customer;
using BMESRestApi.Messages.DataTransferObjects.Order;
using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Messages.DataTransferObjects.Shared;
using BMESRestApi.Models;
using BMESRestApi.Models.Address;
using BMESRestApi.Models.Cart;
using BMESRestApi.Models.Customer;
using BMESRestApi.Models.Order;
using BMESRestApi.Models.Product;
using BMESRestApi.Models.Shared;

namespace BMESRestApi.Messages
{
    public class MessageMapper
    {
        public Brand MapToBrand(BrandDTO parBrandDTO)
        {
            var brand = new Brand
            {
                BrandID = (int) parBrandDTO.Id,
                BrandName = parBrandDTO.Name,
                Slug = parBrandDTO.Slug,
                Description = parBrandDTO.Description,
                MetaDescription = parBrandDTO.MetaDescription,
                MetaKeywords = parBrandDTO.MetaKeywords,
                BrandStatus = (BrandStatus)parBrandDTO.BrandStatus,
                ModifiedDate = parBrandDTO.ModifiedDate,
                IsDeleted = parBrandDTO.IsDeleted
            };

            return brand;
        }

        public BrandDTO MapToBrandDto(Brand parBrand)
        {
            var varBrandDTO = new BrandDTO();

            if (parBrand != null)
            {
                varBrandDTO.Id = parBrand.BrandID;
                varBrandDTO.Name = parBrand.BrandName;
                varBrandDTO.Slug = parBrand.Slug;
                varBrandDTO.Description = parBrand.Description;
                varBrandDTO.MetaDescription = parBrand.MetaDescription;
                varBrandDTO.MetaKeywords = parBrand.MetaKeywords;
                varBrandDTO.BrandStatus = (int) parBrand.BrandStatus;
                varBrandDTO.ModifiedDate = parBrand.ModifiedDate;
                varBrandDTO.IsDeleted = parBrand.IsDeleted;
            }

            return varBrandDTO;
        }

        public Category MapToCategory(CategoryDTO parCategoryDTO)
        {
            var varCategory = new Category
            {
                CategoryID = parCategoryDTO.CategoryID,
                CategoryName = parCategoryDTO.Name,
                Slug = parCategoryDTO.Slug,
                Description = parCategoryDTO.Description,
                MetaDescription = parCategoryDTO.MetaDescription,
                MetaKeywords = parCategoryDTO.MetaKeywords,
                CategoryStatus = (CategoryStatus)parCategoryDTO.CategoryStatus,
                ModifiedDate = parCategoryDTO.ModifiedDate,
                IsDeleted = parCategoryDTO.IsDeleted
            };

            return varCategory;
        }

        public CategoryDTO MapToCategoryDto(Category parCategory)
        {
            return new CategoryDTO
            {
                CategoryID = parCategory.CategoryID,
                Name = parCategory.CategoryName,
                Slug = parCategory.Slug,
                Description = parCategory.Description,
                MetaDescription = parCategory.MetaDescription,
                MetaKeywords = parCategory.MetaKeywords,
                CategoryStatus = (int)parCategory.CategoryStatus,
                ModifiedDate = parCategory.ModifiedDate,
                IsDeleted = parCategory.IsDeleted
            };
        }

        public Product MapToProduct(ProductDTO parProductDTO)
        {
            var product = new Product
            {
                ProductID = (int) parProductDTO.ProductID,
                ProductName = parProductDTO.Name,
                Slug = parProductDTO.Slug,
                Description = parProductDTO.Description,
                MetaDescription = parProductDTO.MetaDescription,
                MetaKeywords = parProductDTO.MetaKeywords,
                SKU = parProductDTO.MetaDescription,
                Model = parProductDTO.MetaKeywords,
                Price = parProductDTO.Price,
                SalesPrice = parProductDTO.SalePrice,
                OldPrice = parProductDTO.OldPrice,
                ImageURL = parProductDTO.ImageUrl,
                QuantityInStock = parProductDTO.QuantityInStock,
                isBestSeller = parProductDTO.IsBestseller,
                CategoryID = parProductDTO.CategoryId,
                BrandID = parProductDTO.BrandId,
                ProductStatus = (ProductStatus)parProductDTO.ProductStatus,
                CreateDate = parProductDTO.CreateDate,
                ModifiedDate = parProductDTO.ModifiedDate,
                IsDeleted = parProductDTO.IsDeleted
            };

            return product;
        }

        public ProductDTO MapToProductDto(Product parProduct)
        {
            var varproductDTO = new ProductDTO();

            if(parProduct != null)
            {
                varproductDTO.ProductID = parProduct.ProductID;
                varproductDTO.Name = parProduct.ProductName;
                varproductDTO.Slug = parProduct.Slug;
                varproductDTO.Description = parProduct.Description;
                varproductDTO.MetaDescription = parProduct.MetaDescription;
                varproductDTO.MetaKeywords = parProduct.MetaKeywords;
                varproductDTO.SKU = parProduct.MetaDescription;
                varproductDTO.Model = parProduct.MetaKeywords;
                varproductDTO.Price = parProduct.Price;
                varproductDTO.SalePrice = parProduct.SalesPrice;
                varproductDTO.OldPrice = parProduct.OldPrice;
                varproductDTO.ImageUrl = parProduct.ImageURL;
                varproductDTO.QuantityInStock = parProduct.QuantityInStock;
                varproductDTO.IsBestseller = parProduct.isBestSeller;
                varproductDTO.CategoryId = parProduct.CategoryID;
                varproductDTO.BrandId = parProduct.BrandID;
                varproductDTO.ProductStatus = (int) parProduct.ProductStatus;
                varproductDTO.CreateDate = parProduct.CreateDate;
                varproductDTO.ModifiedDate = parProduct.ModifiedDate;
                varproductDTO.IsDeleted = parProduct.IsDeleted;
            };

            return varproductDTO;
        }

        public CartDTO MapToCartDto(Cart parCart)
        {
            var varCartDTO = new CartDTO();
            if (parCart != null)
            {
                varCartDTO.CartID = parCart.CartID;
                varCartDTO.UniqueCartId = parCart.UniqueCartId;
                varCartDTO.CartStatus = (int)parCart.CartStatus;
                varCartDTO.CreateDate = parCart.CreateDate;
                varCartDTO.ModifiedDate = parCart.ModifiedDate;
                varCartDTO.IsDeleted = parCart.IsDeleted;
            }
            return varCartDTO;
        }

        public Cart MapToCart(CartDTO parCartDTO)
        {
            var varCart = new Cart();

            if (parCartDTO != null)
            {
                varCart.CartID = parCartDTO.CartID;
                varCart.UniqueCartId = parCartDTO.UniqueCartId;
                varCart.CartStatus = (CartStatus) parCartDTO.CartStatus;
                varCart.CreateDate = parCartDTO.CreateDate;
                varCart.ModifiedDate = parCartDTO.ModifiedDate;
                varCart.IsDeleted = parCartDTO.IsDeleted;
            };

            return varCart;
        }

        public CartItemDTO MapToCartItemDto(CartItem parCartItem)
        {
            CartItemDTO locCartItemDTO = null;

            if (parCartItem.Product != null)
            {
                var productDto = MapToProductDto(parCartItem.Product);

                locCartItemDTO = new CartItemDTO
                {
                    CartItemID = parCartItem.CartItemID,
                    CartID = parCartItem.CartID,
                    Product = productDto,
                    Quantity = parCartItem.Quantity 
                };
            }

            return locCartItemDTO;
        }

        public CartItem MapToCartItem(CartItemDTO parCartItemDTO)
        {
            return new CartItem
            {
                CartID = parCartItemDTO.CartID,
                ProductID = parCartItemDTO.Product.ProductID,
                Quantity = parCartItemDTO.Quantity
            };
        }

        public AddressDTO MapToAddressDto(Address parAddress)
        {
            var varAddressDTO = new AddressDTO();

            if(parAddress != null)
            {
                varAddressDTO.AddressID = parAddress.AddressID;
                varAddressDTO.Name = parAddress.Name;
                varAddressDTO.AddressLine1 = parAddress.AddressLine1;
                varAddressDTO.AddressLine2 = parAddress.AddressLine2;
                varAddressDTO.City = parAddress.City;
                varAddressDTO.Country = parAddress.Country;
                varAddressDTO.State = parAddress.State;
                varAddressDTO.ZipCode = parAddress.ZipCode;
                varAddressDTO.CreateDate = parAddress.CreateDate;
                varAddressDTO.ModifiedDate = parAddress.ModifiedDate;
                varAddressDTO.IsDeleted = parAddress.IsDeleted;

            };

            return varAddressDTO;
        }

        public Address MapToAddress(AddressDTO parAddressDTO)
        {
            var varAddress = new Address();
            if(parAddressDTO != null)
            {
                varAddress.AddressID = parAddressDTO.AddressID;
                varAddress.Name = parAddressDTO.Name;
                varAddress.AddressLine1 = parAddressDTO.AddressLine1;
                varAddress.AddressLine2 = parAddressDTO.AddressLine2;
                varAddress.City = parAddressDTO.City;
                varAddress.Country = parAddressDTO.Country;
                varAddress.State = parAddressDTO.State;
                varAddress.ZipCode = parAddressDTO.ZipCode;
                varAddress.CreateDate = parAddressDTO.CreateDate;
                varAddress.ModifiedDate = parAddressDTO.ModifiedDate;
                varAddress.IsDeleted = parAddressDTO.IsDeleted;
            };
            return varAddress;
        }

        public CustomerDTO MapToCustomerDto(Customer parCustomer)
        {
            var varCustomerDTO = new CustomerDTO
            {
                CustomerID = parCustomer.CustomerID,
                FirstName = parCustomer.Person.FirstName,
                MiddleName = parCustomer.Person.MiddleName,
                LastName = parCustomer.Person.LastName,
                EmailAddress = parCustomer.Person.EmailAddress,
                PhoneNumber = parCustomer.Person.PhoneNumber,
                Gender = (int)parCustomer.Person.Gender,
                DateOfBirth = parCustomer.Person.DateOfBirth,
                CreateDate = parCustomer.CreateDate,
                ModifiedDate = parCustomer.ModifiedDate,
                IsDeleted = parCustomer.IsDeleted
            };

            return varCustomerDTO;
        }
        public Customer MapToCustomer(CustomerDTO parCustomerDTO)
        {
            var varPerson = new Person
            {
                PersonID = parCustomerDTO.CustomerID,
                FirstName = parCustomerDTO.FirstName,
                MiddleName = parCustomerDTO.MiddleName,
                LastName = parCustomerDTO.LastName,
                EmailAddress = parCustomerDTO.EmailAddress,
                PhoneNumber = parCustomerDTO.PhoneNumber,
                Gender = (Gender)parCustomerDTO.Gender,
                DateOfBirth = parCustomerDTO.DateOfBirth,
                CreateDate = parCustomerDTO.CreateDate,
                ModifiedDate = parCustomerDTO.ModifiedDate,
                IsDeleted = parCustomerDTO.IsDeleted
            };

            return new Customer
            {
                CustomerID = parCustomerDTO.CustomerID,
                Person = varPerson
            };
        }

        public PersonDTO MapToPersonDto(Person parPerson)
        {
            var personDTO = new PersonDTO
            {
                PersonID = parPerson.PersonID,
                FirstName = parPerson.FirstName,
                MiddleName = parPerson.MiddleName,
                LastName = parPerson.LastName,
                EmailAddress = parPerson.EmailAddress,
                PhoneNumber = parPerson.PhoneNumber,
                Gender = (int)parPerson.Gender,
                DateOfBirth = parPerson.DateOfBirth,
                CreateDate = parPerson.CreateDate,
                ModifiedDate = parPerson.ModifiedDate,
                IsDeleted = parPerson.IsDeleted
            };

            return personDTO;
        }

        public Person MapToPerson(PersonDTO parPersonDTO)
        {
            return new Person
            {
                PersonID = parPersonDTO.PersonID,
                FirstName = parPersonDTO.FirstName,
                MiddleName = parPersonDTO.MiddleName,
                LastName = parPersonDTO.LastName,
                EmailAddress = parPersonDTO.EmailAddress,
                PhoneNumber = parPersonDTO.PhoneNumber,
                Gender = (Gender)parPersonDTO.Gender,
                DateOfBirth = parPersonDTO.DateOfBirth,
                CreateDate = parPersonDTO.CreateDate,
                ModifiedDate = parPersonDTO.ModifiedDate,
                IsDeleted = parPersonDTO.IsDeleted
            };
        }

        public OrderDTO MapToOrderDto(Order parOrder)
        {
            var orderDto = new OrderDTO
            {
                OrderID = parOrder.OrderID,
                OrderTotal = parOrder.OrderTotal,
                OrderItemTotal = parOrder.OrderTotal,
                ShippingCharge = parOrder.ShippingCharge,
                CustomerId = parOrder.CustomerId,
                OrderStatus = (int)parOrder.OrderStatus,
                CreateDate = parOrder.CreateDate,
                ModifiedDate = parOrder.ModifiedDate,
                IsDeleted = parOrder.IsDeleted
            };

            return orderDto;
        }

        public Order MapToOrder(OrderDTO parOrderDTO)
        {
            return new Order
            {
                OrderID = parOrderDTO.OrderID,
                OrderTotal = parOrderDTO.OrderTotal,
                OrderItemTotal = parOrderDTO.OrderTotal,
                ShippingCharge = parOrderDTO.ShippingCharge,
                CustomerId = parOrderDTO.CustomerId,
                OrderStatus = (OrderStatus)parOrderDTO.OrderStatus,
                CreateDate = parOrderDTO.CreateDate,
                ModifiedDate = parOrderDTO.ModifiedDate,
                IsDeleted = parOrderDTO.IsDeleted
            };
        }

        public OrderItemDTO MapToOrderItemDto(OrderItem parOrderItem)
        {
            OrderItemDTO locOrderItemDTO = null;

            if (parOrderItem?.Product != null)
            {
                var productDTO = MapToProductDto(parOrderItem.Product);

                locOrderItemDTO = new OrderItemDTO
                {
                    OrderItemID = parOrderItem.OrderItemID,
                    OrderID = parOrderItem.OrderItemID,
                    Product = productDTO,
                    Quantity = parOrderItem.Quantity
                };
            }

            return locOrderItemDTO;
        }

        public OrderItem MapToOrderItem(OrderItemDTO parOrderItemDTO)
        {
            return new OrderItem
            {
                OrderID = parOrderItemDTO.OrderID,
                ProductID = parOrderItemDTO.Product.ProductID,
                Quantity = parOrderItemDTO.Quantity
            };
        }

        public List<BrandDTO> MapToBrandDtos(IEnumerable<Brand> parBrands)
        {
            var varBrandDTOs = new List<BrandDTO>();
            foreach (var varBrand in parBrands)
            {
                var varBrandDTO = MapToBrandDto(varBrand);
                varBrandDTOs.Add(varBrandDTO);
            }
            return varBrandDTOs;
        }

        public List<CategoryDTO> MapToCategoryDtos(IEnumerable<Category> parCategories)
        {
            var varCategoryDTOs = new List<CategoryDTO>();
            foreach (var varCategory in parCategories)
            {
                var varCategoryDTO = MapToCategoryDto(varCategory);
                varCategoryDTOs.Add(varCategoryDTO);
            }
            return varCategoryDTOs;
        }

        public List<ProductDTO> MapToProductDtos(IEnumerable<Product> parProducts)
        {
            var varProductDTOs = new List<ProductDTO>();
            foreach (var product in parProducts)
            {
                var productDto = MapToProductDto(product);
                varProductDTOs.Add(productDto);
            }
            return varProductDTOs;
        }

        public List<CartItemDTO> MapToCartItemDtos(IEnumerable<CartItem> cartItems)
        {
            var varCartItemDTOs = new List<CartItemDTO>();
            foreach (var varCartItem in cartItems)
            {
                var cartItemDto = MapToCartItemDto(varCartItem);
                varCartItemDTOs.Add(cartItemDto);
            }
            return varCartItemDTOs;
        }
        public List<AddressDTO> MapToAddressDtos(IEnumerable<Address> parAddresses)
        {
            var varAddressDTOs = new List<AddressDTO>();
            foreach (var varAddress in parAddresses)
            {
                var varAddressDTO = MapToAddressDto(varAddress);
                varAddressDTOs.Add(varAddressDTO);
            }
            return varAddressDTOs;
        }
    }
}
