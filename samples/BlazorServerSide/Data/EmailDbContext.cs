using BlazorServerSide.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorServerSide.Data
{
    public class EmailDbContext: DbContext
    {
        public EmailDbContext(DbContextOptions<EmailDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmailDto> Templates { get; set; }
    }
}
