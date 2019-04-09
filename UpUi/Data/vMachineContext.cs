using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UpUi.Models;

namespace UpUi.Data
{
    public class vMachineContext : DbContext
    {
        public vMachineContext(DbContextOptions<vMachineContext> options) : base(options)
        {

        }

        public DbSet<vMachine> vMachines { get; set; }
        public DbSet<vMachineNetwork> vMachineNetwork { get; set; }
    }
}
