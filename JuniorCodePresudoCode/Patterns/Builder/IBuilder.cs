using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        void Select(string columns);
        void From(string table);
        void Where(string condition);
        Query GetQuery();

    }
}
