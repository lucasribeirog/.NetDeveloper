using EcommerceAPI.Core.Interfaces.Repositories;
using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Infrastructure.Data.Repositories
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly EcommerceContext _ecommerceContext;

        public RepositoryUser(EcommerceContext ecommerceContext)
            : base(ecommerceContext)
        {
            this._ecommerceContext = ecommerceContext;
        }
    }
}