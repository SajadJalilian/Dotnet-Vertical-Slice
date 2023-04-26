namespace Ecommerce.Persistence;

public interface IUnitOfWork
{
    // ISubscriptionRepository Subscriptions { get; }
    Task<bool> CommitAsync();
}