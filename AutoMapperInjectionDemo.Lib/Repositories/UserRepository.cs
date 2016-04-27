using AutoMapper;
using AutoMapperInjectionDemo.Lib.Interfaces;
using AutoMapperInjectionDemo.Lib.Models.Database;
using AutoMapperInjectionDemo.Lib.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperInjectionDemo.Lib.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IMapper _mapper;

        public UserRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<User> GetAll()
        {
            List<DbUser> dbUsers = new List<DbUser>()
            {
                new DbUser()
                {
                    ID = 1,
                    Username = "Anorak",
                    FirstName = "James",
                    LastName = "Halliday",
                    AccessLevelID = 2
                },
                new DbUser()
                {
                    ID = 2,
                    Username = "Great and Powerful Og",
                    FirstName = "Ogden",
                    LastName = "Morrow",
                    AccessLevelID = 2
                },
                new DbUser()
                {
                    ID = 1020994,
                    Username = "Parzival",
                    FirstName = "Wade",
                    LastName = "Watts",
                    AccessLevelID = 1
                }
            };

            return _mapper.Map<List<User>>(dbUsers);
        }
    }
}
