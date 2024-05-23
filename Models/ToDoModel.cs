

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Models
{
    [Table("ToDo")]
    public class ToDoModel
    {
        public int Id { get; set; }
        [DisplayName("Task Name")]
        public string? TaskName { get; set; }
        [DisplayName("Is task Completed")]
        public bool IsCompleted { get; set; }
    }
}
