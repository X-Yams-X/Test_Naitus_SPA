using TestNaitus.Domains;

namespace TestNaitus.Infrastructure;

public class UserRepository : IUserRepository
{
    public Task<User?> CreateAsync(User u)
    {
        throw new NotImplementedException();
    }

    public Task<User?> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User?> RetrieveAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<User?> UpdateAsync(string id, User c)
    {
        throw new NotImplementedException();
    }
}
