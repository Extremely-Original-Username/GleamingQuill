using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using GleamingQuill.Model;

namespace GleamingQuill.Data
{
    public class WorldContext: DbContext
    {
        public string worldName;
        public DbSet<Article> articles { get; set; }

        public WorldContext(string worldName) : base()
        {
            this.worldName = worldName;
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Directory.CreateDirectory(".\\Saved");
            optionsBuilder.UseSqlite("Data Source=.\\Saved\\" + worldName + ".mdf;Mode=ReadWriteCreate;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
