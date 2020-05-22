using BMESRestApi.Messages;
using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Messages.Request.Brand;
using BMESRestApi.Messages.Request.Category;
using BMESRestApi.Messages.Response.Brand;
using BMESRestApi.Messages.Response.Category;
using BMESRestApi.Repositories.Contracts;
using BMESRestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private MessageMapper _messageMapper;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _messageMapper = new MessageMapper();
        }

        //public CreateCategoryResponse SaveCategory(CreateCategoryRequest parCreateCategoryRequest)
        //{
        //    var varCategory = _messageMapper.MapToCategory(parCreateCategoryRequest.propCategoryDTO);
        //    _categoryRepository.Save();
        //    var categoryDto = _messageMapper.MapToCategoryDTO(varCategory);

        //    var createCategoryResponse = new CreateCategoryResponse
        //    {
        //        Category = categoryDto
        //    };

        //    return createCategoryResponse;
        //}

        //public UpdateCategoryResponse EditCategory(UpdateCategoryRequest parUpdateCategoryRequest)
        //{
        //    UpdateCategoryResponse locUpdateCategoryResponse = null;

        //    if (parUpdateCategoryRequest.CategoryID == parUpdateCategoryRequest.locCategoryDTO.CategoryID)
        //    {
        //        var varCategory = _messageMapper.MapToCategory(parUpdateCategoryRequest.locCategoryDTO);
        //        _categoryRepository.Update(varCategory);
        //        var varCategoryDTO = _messageMapper.MapToCategoryDto(varCategory);

        //        locUpdateCategoryResponse = new UpdateCategoryResponse
        //        {

        //        };
        //    }
        //    return locUpdateCategoryResponse;
        //}

        public GetCategoryResponse GetCategory(GetCategoryRequest parGetCategoryRequest)
        {
            GetCategoryResponse locGetCategoryResponse = null;

            if (parGetCategoryRequest.CategoryID > 0)
            {
                var varCategory = _categoryRepository.FindByID(parGetCategoryRequest.CategoryID);
                var varCategoryDTO = _messageMapper.MapToCategoryDto(varCategory);

                locGetCategoryResponse = new GetCategoryResponse
                {
                    locCategoryDTO = varCategoryDTO
                };
            }

            return locGetCategoryResponse;
        }

        //public FetchCategoriesResponse GetCategories(FetchCategoryRequest parFetchCategoryRequest)
        //{
        //    var varCategories = _categoryRepository.FindAll();
        //    var varCategoryDTOs = _messageMapper.MapToCategoryDtos(varCategories);

        //    return new FetchCategoriesResponse
        //    {
        //        Categories = varCategoryDTOs
        //    };
        //}

        //public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deleteCategoryRequest)
        //{
        //    var category = _categoryRepository.FindCategoryById(deleteCategoryRequest.Id);
        //    _categoryRepository.DeleteCategory(category);
        //    var categoryDto = _messageMapper.MapToCategoryDto(category);

        //    return new DeleteCategoryResponse
        //    {
        //        Category = categoryDto
        //    };
        //}
    }
}
