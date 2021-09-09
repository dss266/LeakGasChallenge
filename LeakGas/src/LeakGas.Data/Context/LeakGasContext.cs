using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeakGas.Data.Context
{
    public class LeakGasContext : DbContext
    {
        public LeakGasContext(DbContextOptions<LeakGasContext> options) : base(options)
        {

        }
    }
}
