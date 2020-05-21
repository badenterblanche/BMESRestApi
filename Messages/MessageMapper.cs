using BMESRestApi.Messages.DataTransferObjects.Product;
using BMESRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Messages
{
    public class MessageMapper
    {
        public Brand MapToBrand(BrandDTO parBrandDTO)
        {
            var locBrand = new Brand
            {
                BrandID = parBrandDTO.BrandID,
                BrandName = parBrandDTO.BrandName,
                Slug = parBrandDTO.Slug,
                Description = parBrandDTO.Description,
                MetaKeyWords = parBrandDTO.MetaKeyWords,
                BrandStatus = parBrandDTO.BrandStatus,
                isDeleted = parBrandDTO.isDeleted
            };
            return locBrand;
        }

        public BrandDTO MapToBrandDTO(Brand parBrand)
        {
            var locBrandDTO = new BrandDTO
            {
                BrandID = parBrand.BrandID,
                BrandName = parBrand.BrandName,
                Slug = parBrand.Slug,
                Description = parBrand.Description,
                MetaKeyWords = parBrand.MetaKeyWords,
                BrandStatus = parBrand.BrandStatus,
                isDeleted = parBrand.isDeleted
            };
            return locBrandDTO;
        }
    }
}
