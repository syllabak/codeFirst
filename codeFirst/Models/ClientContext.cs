using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class ClientContext:DbContext
    {
        public ClientContext() : base("Conn") { }
        public DbSet<Client> clients { get; set; }
    }
}