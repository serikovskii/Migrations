using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Migrations
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}