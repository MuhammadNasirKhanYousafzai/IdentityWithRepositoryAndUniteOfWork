using Application.Domain.Entities;
using Application.Domain.Ropsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.Repositories
{
    internal class RoleRepository : Repository<Role>, IRoleRepository
    {
        internal RoleRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Role FindByName(string roleName)
        {
            return Set.FirstOrDefault(x => x.Name == roleName);
        }

        //public Task<Role> FindByNameAsync(string roleName)
        //{
        //    return Set.FirstOrDefaultAsync(x => x.Name == roleName);
        //}

        //public Task<Role> FindByNameAsync(System.Threading.CancellationToken cancellationToken, string roleName)
        //{
        //    return Set.FirstOrDefaultAsync(x => x.Name == roleName, cancellationToken);
        //}


        public Task<Role> FindByNameAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<Role> FindByNameAsync(System.Threading.CancellationToken cancellationToken, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
