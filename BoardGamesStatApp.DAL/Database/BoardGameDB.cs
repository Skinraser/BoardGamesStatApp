using BoardGamesStatApp.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesStatApp.DAL
{
    public class BoardGameDB : DbContext
    {
        public DbSet<BoardGame> BoardGames { get; set; } 
        public BoardGameDB(DbContextOptions<BoardGameDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Keep this method for backwards compatibility.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
