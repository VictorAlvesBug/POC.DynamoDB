﻿using POC.DynamoDB.Application.Dtos;

namespace POC.DynamoDB.Application.Interfaces
{
	public interface IProductService
	{
		Task<ProductDto> GetByPkAndSkAsync(string pk, string sk);
	}
}
