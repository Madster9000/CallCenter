using System;
using System.Security.Principal;

namespace Support.Services.Interfaces
{
    public interface ISystemUsersService
    {
        Guid FindUserIdByIdentity(IIdentity userIdentity);
    }
}