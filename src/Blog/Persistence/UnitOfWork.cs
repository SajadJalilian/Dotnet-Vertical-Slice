namespace Blog.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    // public ISubscriptionRepository Subscriptions { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        // Users = new UserRepository(_context);
    }

    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}