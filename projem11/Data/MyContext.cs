using Microsoft.EntityFrameworkCore;
using projem11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projem11.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders{ get; set; }
    }
}
