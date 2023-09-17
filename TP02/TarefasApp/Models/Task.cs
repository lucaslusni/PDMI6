using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Models
{
    public class Task
    {
        public Task(int Id, string Title, string Description, DateTime Created, int Priority)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Created = Created;
            this.Priority = Priority;   
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Priority { get; set; }
    }
}
