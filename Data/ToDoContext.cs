using ToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> _options) : base(_options)
        {

        }
        public DbSet<ToDoModel> ToDos { get; set; }
    }
}
