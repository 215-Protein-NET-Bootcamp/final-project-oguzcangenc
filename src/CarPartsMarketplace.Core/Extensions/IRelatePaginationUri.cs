using CarPartsMarketplace.Core.Utilities.Pagination;

namespace CarPartsMarketplace.Core.Extensions
{
    public interface IRelatePaginationUri
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
