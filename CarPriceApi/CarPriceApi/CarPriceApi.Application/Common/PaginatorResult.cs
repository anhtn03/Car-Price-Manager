using System;
using System.Collections.Generic;

namespace CarPriceApi.CarPriceApi.Application.Common
{
    public class PaginatorResult<TModel>
    {
        public List<TModel> Data { get; set; }

        public int Total { get; set; }

        public PaginatorResult(List<TModel> data, int total)
        {
            Data = data;
            Total = total;
        }
    }
}
