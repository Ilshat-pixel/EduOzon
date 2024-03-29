﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.Domain.SeedWork;

namespace MerchandiseService.Domain.MerchOrderAggregation
{
    public interface IMerchOrderRepository : IRepository<MerchOrder>
    {
        Task<int>  Add
        Task<MerchOrder> FindByIdAsync(long id, CancellationToken cancellationToken = default);
        
        Task<List<MerchOrder>> FindByEmployeeIdAsync(long id, CancellationToken cancellationToken = default);
    }
}