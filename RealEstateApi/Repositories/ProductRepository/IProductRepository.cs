﻿using RealEstateApi.Dtos.ProductDetailDtos;
using RealEstateApi.Dtos.ProductDtos;

namespace RealEstateApi.Repositories.ProductRepository
{
	public interface IProductRepository
	{
		Task<List<ResultProductDto>> GetAllProductAsync();
		Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
		Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByTrue(int id);
		Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByFalse(int id);
		Task ProductDealOfTheDayStatusChangeToTrue(int id);
		Task ProductDealOfTheDayStatusChangeToFalse(int id);
		Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
		Task<List<ResultLast3ProductWithCategoryDto>> GetLast3ProductAsync();
		Task CreateProduct(CreateProductDto createProductDto);
		Task<GetProductByProductIdDto> GetProductByProductId(int id);
		Task<GetProductDetailByIdDto> GetProductDetailByProductId(int id);
		Task<List<ResultProductWithSearchListDto>> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryId, string city);
		Task<List<ResultProductWithCategoryDto>> GetProductByDealOfTheDayTrueWithCategoryAsync();
	}
}
