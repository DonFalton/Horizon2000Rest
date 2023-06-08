using Horizon2000Rest.Entity.Models;
using System.Collections.Generic;

/// <summary>
/// Interface for managing product category operations.
/// </summary>
public interface IProductCategoryWorker
{
    /// <summary>
    /// Retrieves all product categories.
    /// </summary>
    /// <returns>A list of product categories.</returns>
    List<ProductCategoryDbo> GetAllProductCategories();

    /// <summary>
    /// Retrieves a product category by ID.
    /// </summary>
    /// <param name="id">The ID of the product category.</param>
    /// <returns>The product category.</returns>
    ProductCategoryDbo GetProductCategory(int id);

    /// <summary>
    /// Adds a new product category.
    /// </summary>
    /// <param name="productCategory">The ProductCategoryDbo object containing the product category data.</param>
    void AddProductCategory(ProductCategoryDbo productCategory);

    /// <summary>
    /// Updates an existing product category.
    /// </summary>
    /// <param name="productCategory">The ProductCategoryDbo object containing the updated product category data.</param>
    void UpdateProductCategory(ProductCategoryDbo productCategory);
}
