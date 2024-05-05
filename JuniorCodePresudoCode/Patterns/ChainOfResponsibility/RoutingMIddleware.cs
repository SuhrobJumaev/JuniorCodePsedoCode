using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.ChainOfResponsibility
{
    public class RoutingMiddleware : BaseMIddleware
    {
        public async override Task<ApiResponse> Procces(Request request)
        {
            //Some logic send requests to service and 

            _response.Code = 1;
            _response.Message = "Request is in process!";

            //Can do some logic 
            return _response;
        }

    }
}
