using HotSauceApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Data
{
    public class HotSauceDbContext : DbContext
    {
        public HotSauceDbContext(DbContextOptions<HotSauceDbContext> options): base(options)
        {

        }
    }
}
