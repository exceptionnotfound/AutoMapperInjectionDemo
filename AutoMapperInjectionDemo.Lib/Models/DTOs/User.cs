using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperInjectionDemo.Lib.Models.DTOs
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public string Username { get; set; }
    }
}
