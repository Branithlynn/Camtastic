using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Intership.Entity;

namespace Intership.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DBContext() : base("Server = localhost\\sqlexpress; Database=Camtastic.dbo;Trusted_Connection=True;")
        {
            Cameras = this.Set<Camera>();
            Photos = this.Set<Photo>();
        }
        

    }
}
