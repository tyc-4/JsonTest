using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTest
{
    class Details
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Details(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
