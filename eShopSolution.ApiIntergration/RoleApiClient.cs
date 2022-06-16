using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Roles;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntergration
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {
        public RoleApiClient(
            IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }
        public async Task<ApiResult<List<RoleVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<RoleVm>>>("/api/roles");
        }
    }
}