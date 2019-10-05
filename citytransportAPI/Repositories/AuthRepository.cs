using System.Threading.Tasks;
using citytransportAPI.Repositories.Interfaces;
using Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace citytransportAPI.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _dataContext;

        public AuthRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Player> Login(string login, string password)
        {
            var player = await _dataContext.Players.FirstOrDefaultAsync(x => x.Login == login);

            if (player == null)
                return null;

            if (!VerifyPasswordHash(password, player.PasswordHash, player.PasswordSalt))
                return null;

            return player;
        }

        public async Task<bool> PlayerExists(string login)
        {
            return await _dataContext.Players.AnyAsync(x => x.Login == login);
        }

        public async Task<Player> Register(Player player, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            player.PasswordHash = passwordHash;
            player.PasswordSalt = passwordSalt;

            await _dataContext.Players.AddAsync(player);
            await _dataContext.SaveChangesAsync();

            return player;
        }

        #region Useful methods

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }

            return true;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


        #endregion
    }
}