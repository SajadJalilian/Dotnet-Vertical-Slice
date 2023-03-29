namespace Blog.Persistence;

public interface IUnitOfWork
{
    // ISubscriptionRepository Subscriptions { get; }
    Task<bool> CommitAsync();
}