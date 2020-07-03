using DotNetOpenAuth.InfoCard;
using Microsoft.AspNetCore.Http;
/*using Microsoft.AspNetCore.Http*/
//using Microsoft.AspNetCore.Http;
using MyOrders.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyOrders.Api.Services
{
    public class GetcurrentUserService 
    {
      
        public GetcurrentUserService()
        {
            this.username = new HttpContextAccessor().HttpContext.User.Identity.Name;
        }
        public string username
        {
            get;
        }
    }


    public class UserResolverService: IGetcurrentUserService
    {
        private readonly IHttpContextAccessor _context;
        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUser()
        {
            return _context.HttpContext.User?.Identity?.Name;
        }
    }
}
