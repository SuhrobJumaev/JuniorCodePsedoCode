using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.ChainOfResponsibility
{
    public class ValidationMiddleware : BaseMIddleware
    {
        public async override Task<ApiResponse> Procces(Request request)
        {
            //Some logic fluent validation or custom validation 

            if (_next is not null)
            {
                _response = await _next.Procces(request);
            }

            //Can do some logic 
            return _response;
        }

    }
}
