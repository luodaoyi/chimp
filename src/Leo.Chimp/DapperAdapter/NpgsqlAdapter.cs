using System;
using System.Collections.Generic;
using System.Text;

namespace Leo.Chimp.DapperAdapter
{
    public class NpgsqlAdapter : ISqlAdapter
    {
        public virtual string PagingBuild(ref PartedSql partedSql, object args, long skip, long take)
        {
            var pageSql = $"{partedSql.Raw} LIMIT {take} OFFSET {skip}";
            return pageSql;
        }

    }
}
