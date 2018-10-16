using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNetUdemy.Model
{
    public class Person
    {
        public long id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Adress { get; set; }
        public string gender { get; set; }
    }
}
