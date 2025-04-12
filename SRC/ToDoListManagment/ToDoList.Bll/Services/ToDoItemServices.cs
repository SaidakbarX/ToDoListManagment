using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DAL.Entity;

namespace ToDoList.Bll.Services
{
   public class ToDoItemServices : IToDoItemServices
    {

        public async Task AddToDoItemAsync(ToDoItem item)
        {
           
        }

        public Task DeleteToDoItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllToDoItemsAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task GetByDueDateAsync(DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        public Task GetCompletedAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task GetIncompletedAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task GetToDoItemByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoItemAsync(ToDoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
