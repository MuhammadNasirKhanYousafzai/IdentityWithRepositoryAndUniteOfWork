using Application.Domain.Entities;
using Application.Domain.Ropsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Repositories
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        internal UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public User FindByUserName(string username)
        {
            return Set.FirstOrDefault(x => x.UserName == username);
        }

        //public Task<User> FindByUserNameAsync(string username)
        //{
        //    return Set.FirstOrDefaultAsync(x => x.UserName == username);
        //}

        //public Task<User> FindByUserNameAsync(System.Threading.CancellationToken cancellationToken, string username)
        //{
        //    return Set.FirstOrDefaultAsync(x => x.UserName == username, cancellationToken);
        //}


        public Task<User> FindByUserNameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByUserNameAsync(System.Threading.CancellationToken cancellationToken, string username)
        {
            throw new NotImplementedException();
        }

        public User FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByEmailAsync(System.Threading.CancellationToken cancellationToken, string email)
        {
            throw new NotImplementedException();
        }
    }
}
