using BMESRestApi.Messages;
using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Messages.Request.Brand;
using BMESRestApi.Messages.Response.Brand;
using BMESRestApi.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Services.Implementations
{
    public class BrandService : IBrandService
    {

        private readonly IBrandRepository _BrandRepository;
        private MessageMapper _MessageMapper;

        public BrandService(IBrandRepository parBrandRepository)
        {
            _BrandRepository = parBrandRepository;
            _MessageMapper = new MessageMapper();
        }

        public CreateBrandResponse SaveBrand(CreateBrandRequest parBrandRequest)
        {
            var varBrand = _MessageMapper.MapToBrand(parBrandRequest.locBrandDTO);
            _BrandRepository.Save();
            var varBrandDTO = _MessageMapper.MapToBrandDTO(varBrand);

            CreateBrandResponse locCreateBrandResponse = new CreateBrandResponse
            {
                locBrandDTO = varBrandDTO
            };

            return locCreateBrandResponse;

        }

    }
}
