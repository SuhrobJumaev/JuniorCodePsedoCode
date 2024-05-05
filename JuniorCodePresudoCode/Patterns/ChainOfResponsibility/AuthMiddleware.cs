using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.ChainOfResponsibility
{
    public class AuthMiddleware : BaseMIddleware
    {
        public async override Task<ApiResponse> Procces(Request request)
        {
            //Some logic send to Identify provider or check cooke

            //Here we can return response if we have some error with auth
            if(_next is not null)
            {
                _response =  await _next.Procces(request);
            }

            //Can do some logic 
            return _response;
        }
    }
}
