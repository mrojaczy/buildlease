﻿using Contracts.Requests;
using Contracts.Views;

namespace Services.Abstractions
{
    public interface ICatalogueService
    {
        CategoryFullView[] GetAllCategories();
        CategoryFilterView[] GetCategoryFilters(int categoryId);
        int GetProductsCount(GetProductsRequest request);
        ProductView[] GetProducts(GetProductsRequest request, string userId);
        ProductFullView GetProduct(int productId, string userId);
    }
}
