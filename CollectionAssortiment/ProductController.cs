﻿using CollectionEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssortiment
{
    public class ProductController : IProduct
    {
        private readonly Uri devUrl = new Uri("https://localhost:44380");
        private readonly Uri prodUrl = new Uri("https://kantine-product-service.azurewebsites.net");

        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://kantine-product-service.azurewebsites.net")
    };

        public async Task<List<ProductDTO>> ReadAllAsync()
        {
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json")
            //);

            HttpResponseMessage response = await client.GetAsync("/api/product");
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<ProductDTO>>(result);
        }

        public async Task<ProductDTO> ReadOneAsync(int id)
        {
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json")
            //);

            HttpResponseMessage response = await client.GetAsync("/api/product/" + id);
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ProductDTO>(result);
        }
    }
}
