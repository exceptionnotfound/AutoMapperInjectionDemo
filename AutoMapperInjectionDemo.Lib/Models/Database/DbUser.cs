using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperInjectionDemo.Lib.Models.Database
{
    public class DbUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccessLevelID { get; set; }
        public string Username { get; set; }
    }
}
