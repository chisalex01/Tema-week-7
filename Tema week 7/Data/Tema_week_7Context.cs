﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tema_week_7.Models;

namespace Tema_week_7.Data
{
    public class Tema_week_7Context : DbContext
    {
        public Tema_week_7Context (DbContextOptions<Tema_week_7Context> options)
            : base(options)
        {
        }

        public DbSet<Tema_week_7.Models.Duckbill> Duckbill { get; set; }
    }
}
