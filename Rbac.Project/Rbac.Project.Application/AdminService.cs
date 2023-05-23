using Rbac.Project.Domain;
using Rbac.Project.Repositories;
using System;

namespace Rbac.Project.Application
{
    public class AdminService
    {
        private readonly IRepository<UserTable> repository;
        public AdminService(IRepository<UserTable> repository)
        {
            this.repository = repository;
        }
    }
}
