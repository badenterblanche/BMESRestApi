using BMESRestApi.Messages.Request.Product;
using BMESRestApi.Messages.Response.Product;

namespace BmesRestApi.Services
{
    public interface ICatalogueService
    {
        FetchProductsResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}
