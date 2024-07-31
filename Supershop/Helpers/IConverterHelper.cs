using System;
using Supershop.Data.Entities;
using Supershop.Models;

namespace Supershop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, Guid imageId, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
