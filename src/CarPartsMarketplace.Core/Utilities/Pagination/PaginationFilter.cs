using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Core.Utilities.Pagination
{
    public class PaginationFilter
    {

        public int PageNumber { get; }
        public int PageSize { get; }

        public PaginationFilter(int page, int pageSize)
        {
            PageNumber = page;
            PageSize = pageSize;

            if (PageNumber <= 0)
                PageNumber = 1;

            if (PageSize <= 0 || PageSize > 20)
                PageSize = 10;
        }
    }
}
