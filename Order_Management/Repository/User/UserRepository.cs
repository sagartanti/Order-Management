using System.Data;
using Dapper;
using Domain;

namespace Repository.User
{
    public class UserRepository 
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        //// IUserStore<ApplicationUser> Implementation
        //public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        //{
        //    const string sql = "INSERT INTO Users (Id, UserName, NormalizedUserName, Email, NormalizedEmail, PasswordHash) " +
        //                       "VALUES (@Id, @UserName, @NormalizedUserName, @Email, @NormalizedEmail, @PasswordHash)";
        //    var rows = await _dbConnection.ExecuteAsync(sql, user);
        //    return rows > 0 ? IdentityResult.Success : IdentityResult.Failed();
        //}

        //public async Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        //{
        //    const string sql = "DELETE FROM Users WHERE Id = @Id";
        //    var rows = await _dbConnection.ExecuteAsync(sql, new { user.Id });
        //    return rows > 0 ? IdentityResult.Success : IdentityResult.Failed();
        //}

        //public async Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        //{
        //    const string sql = "SELECT * FROM Users WHERE Id = @Id";
        //    return await _dbConnection.QuerySingleOrDefaultAsync<ApplicationUser>(sql, new { Id = userId });
        //}

        //public async Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        //{
        //    const string sql = "SELECT * FROM Users WHERE NormalizedUserName = @NormalizedUserName";
        //    return await _dbConnection.QuerySingleOrDefaultAsync<ApplicationUser>(sql, new { NormalizedUserName = normalizedUserName });
        //}

        //public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        //    => Task.FromResult(user.NormalizedUserName);

        //public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        //    => Task.FromResult(user.Id);

        //public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        //    => Task.FromResult(user.UserName);

        //public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        //{
        //    user.NormalizedUserName = normalizedName;
        //    return Task.CompletedTask;
        //}

        //public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        //{
        //    user.UserName = userName;
        //    return Task.CompletedTask;
        //}

        //public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        //{
        //    const string sql = "UPDATE Users SET UserName = @UserName, NormalizedUserName = @NormalizedUserName, Email = @Email, NormalizedEmail = @NormalizedEmail, PasswordHash = @PasswordHash WHERE Id = @Id";
        //    var rows = _dbConnection.Execute(sql, user);
        //    return rows > 0 ? Task.FromResult(IdentityResult.Success) : Task.FromResult(IdentityResult.Failed());
        //}

        //// IUserPasswordStore<ApplicationUser> Implementation
        //public Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        //    => Task.FromResult(user.PasswordHash);

        //public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        //    => Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));

        //public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        //{
        //    user.PasswordHash = passwordHash;
        //    return Task.CompletedTask;
        //}

        //// Dispose Resources
        //public void Dispose()
        //{
        //    // Dispose resources if necessary
        //}
    }
}
