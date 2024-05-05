using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Patterns.Builder
{
    internal class PostgreSQLBuilder : IBuilder
    {
        private StringBuilder queryBuilder = new StringBuilder();
        public DynamicParameters  parameters = new ();

        public PostgreSQLBuilder()
        {
            Reset();
        }

        public void Select(string columns)
        {
            queryBuilder.Append($"SELECT {columns} ");
        }

        public void From(string table)
        {
            queryBuilder.Append($"FROM {table} ");
        }

        public void Where(string condition)
        {
            queryBuilder.Append($"WHERE {condition} ");
        }

        public void Reset()
        {
            queryBuilder = new();
            parameters = new();
        }

        public Query GetQuery()
        {
            return new Query(queryBuilder.ToString(), parameters);
        }
    }
}
