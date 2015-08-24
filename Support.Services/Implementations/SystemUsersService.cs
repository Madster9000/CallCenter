using System;
using System.Linq;
using System.Security.Principal;
using Support.Crm.Model.Entities;
using Support.Crm.Repository.Interfaces;
using Support.Services.Interfaces;

namespace Support.Services.Implementations
{
    public class SystemUsersService: ISystemUsersService
    {
        private readonly IRepository<SystemUser> mSystemUsersRepository;

        public SystemUsersService(IRepository<SystemUser> systemUsersRepository)
        {
            mSystemUsersRepository = systemUsersRepository;
        }

        public Guid FindUserIdByIdentity(IIdentity userIdentity)
        {
            var currentUserId =
                mSystemUsersRepository
                .GetAll()
                .Where(u => u.DomainName == userIdentity.Name)
                .Select(u => u.Id)
                .FirstOrDefault();

            return currentUserId;
        }
    }
}