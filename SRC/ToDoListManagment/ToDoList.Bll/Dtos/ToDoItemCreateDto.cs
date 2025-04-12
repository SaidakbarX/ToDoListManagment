using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Bll.Dtos;

public class ToDoItemCreateDto
{
    public string Title { get; set; }
    public string Discription { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
}
