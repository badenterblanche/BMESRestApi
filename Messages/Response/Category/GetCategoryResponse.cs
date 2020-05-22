namespace BMESRestApi.Messages.Response.Category
{
    using DataTransferObjects.Product;
    public class GetCategoryResponse:ResponseBase
    {
        public CategoryDTO locCategoryDTO { get; set; }
    }
}
