﻿namespace RealEstateApi.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
		public string Type { get; set; }
		public string SlugUrl { get; set; }
        public int ProductCategory { get; set; }
    }
}
