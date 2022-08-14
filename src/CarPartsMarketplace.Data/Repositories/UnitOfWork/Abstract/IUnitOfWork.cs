namespace CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        Task CompleteAsync();
        void Complete();
    }
}
