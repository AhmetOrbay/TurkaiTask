﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turkai.Model.Dtos;
using Turkai.Model.Entity;

namespace Turkai.Service.Interfaces
{
    public interface IRedisService
    {
        Task<ProductDto> GetDataRedis(long Id);
        Task<bool> ImportProduct(long productId);
    }
}
