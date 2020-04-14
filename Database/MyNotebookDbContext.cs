using Application;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class MyNotebookDbContext : DbContext, IMyNotebookDbContext
    {
    }
}
