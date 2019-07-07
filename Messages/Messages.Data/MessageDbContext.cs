using Messages.Models;
using Microsoft.EntityFrameworkCore;

namespace Messages.Data
{
    public class MessageDbContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }

        public MessageDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
