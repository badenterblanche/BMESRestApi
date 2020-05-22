using System;
using System.Collections.Generic;
using System.Linq;
using BmesRestApi.Services;
using BMESRestApi.Messages;
using BMESRestApi.Messages.Request.Product;
using BMESRestApi.Messages.Response.Product;
using BMESRestApi.Models.Product;
using BMESRestApi.Repositories;
using BMESRestApi.Repositories.Contracts;

namespace BMESRestApi.Services.Implementations
{
    public class CatalogueService : ICatalogueService
    {
        private IProductRepository _productRepository;
        private MessageMapper _messageMapper;

        public CatalogueService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _messageMapper = new MessageMapper();
        }
        public FetchProductsResponse FetchProducts(FetchProductsRequest fetchProductsRequest)
        {

            IEnumerable<Product> products = new List<Product>();

            int productCount = 0;

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                productCount = _productRepository.FindAll().Count();
                products = _productRepository.FindAll()
                   .Where(product => product.ProductStatus == ProductStatus.Active)
                   .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                   .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.FindAll()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.CategoryClass.Slug == fetchProductsRequest.CategorySlug &&
                                                                           product.BrandClass.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                var filteredProducts = _productRepository.FindAll()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.CategoryClass.Slug == fetchProductsRequest.CategorySlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = _productRepository.FindAll()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.BrandClass.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            var totalPages = (int)Math.Ceiling((decimal)productCount / fetchProductsRequest.ProductsPerPage);

            int[] pages = Enumerable.Range(1, totalPages).ToArray();

            var productDtos = _messageMapper.MapToProductDtos(products);

            var fetchProductsResponse = new FetchProductsResponse()
            {
                ProductsPerPage = fetchProductsRequest.ProductsPerPage,
                Products = productDtos,
                HasPreviousPages = (fetchProductsRequest.PageNumber > 1),
                CurrentPage = fetchProductsRequest.PageNumber,
                HasNextPages = (fetchProductsRequest.PageNumber < totalPages),
                Pages = pages
            };

            return fetchProductsResponse;
        }
    }
}
