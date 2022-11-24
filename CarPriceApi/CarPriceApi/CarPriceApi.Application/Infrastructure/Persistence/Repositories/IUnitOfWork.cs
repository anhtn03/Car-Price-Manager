namespace CarPriceApi.CarPriceApi.Application.Infrastructure.Persistence.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
