namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync(CancellationToken cancellationToken);
    }
}
