using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.ChainOfResponsibility
{
    public interface IMiddleware
    {
        Task<ApiResponse> Procces(Request request);
        IMiddleware Next(IMiddleware nextMiddleware);
    }
}
