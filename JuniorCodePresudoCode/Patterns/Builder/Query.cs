using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.Builder
{
    public class Query
    {
        public string SqlQuery { get; private set; }
        public DynamicParameters  Parameters { get; private set; }

        public Query(string sqlQuery, DynamicParameters parameters)
        {
            SqlQuery = sqlQuery;
            Parameters = parameters;
        }
    }
}
