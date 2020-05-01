using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class MyNotebookDbContext : DbContext, IMyNotebookDbContext
    {
        public MyNotebookDbContext(DbContextOptions<MyNotebookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
