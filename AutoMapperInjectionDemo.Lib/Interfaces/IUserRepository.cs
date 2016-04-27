using AutoMapperInjectionDemo.Lib.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperInjectionDemo.Lib.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
