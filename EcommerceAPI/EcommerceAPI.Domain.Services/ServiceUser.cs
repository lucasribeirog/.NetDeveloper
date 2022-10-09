using EcommerceAPI.Core.Interfaces.Repositories;
using EcommerceAPI.Core.Interfaces.Services;
using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Domain.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser)
            : base(repositoryUser)
        {
            this._repositoryUser = repositoryUser;
        }
    }
}