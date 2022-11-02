using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class BddContext : DbContext
    {
        public DbSet<User> Users { get; set;}
    }
}