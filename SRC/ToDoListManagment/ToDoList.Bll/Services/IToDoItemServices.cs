using ToDoList.DAL.Entity;

namespace ToDoList.Bll.Services
{
    public interface IToDoItemServices
    {
        Task AddToDoItemAsync(ToDoItem item);
        Task DeleteToDoItemByIdAsync(int id);
        Task UpdateToDoItemAsync(ToDoItem item);
        Task GetAllToDoItemsAsync(int skip, int take);
        Task GetToDoItemByIdAsync();
        Task GetByDueDateAsync(DateTime dueDate);
        Task GetCompletedAsync( int skip, int take);
        Task GetIncompletedAsync(int skip, int  take);
    }
}