using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.ChainOfResponsibility
{
    public abstract class BaseMIddleware : IMiddleware
    {
        protected IMiddleware _next;
        protected ApiResponse _response = new();

        public IMiddleware Next(IMiddleware nextMiddleware)
        {
            _next = nextMiddleware;
            return _next;
        }

        public virtual async Task<ApiResponse> Procces(Request request)
        {
            //Some logic

            if (_next is not null)
            {
                _response = await _next.Procces(request);
            }

            //Can do some logical 

            return _response;
        }
    }
}
