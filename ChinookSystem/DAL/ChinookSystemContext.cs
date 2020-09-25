﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Entities;
#endregion

namespace ChinookSystem.DAL
{
    internal class ChinookSystemContext : DbContext
    {
        public ChinookSystemContext() : base("name=ChinookDB")
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}