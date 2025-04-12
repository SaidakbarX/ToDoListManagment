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
        Task GetCompletedAsync(skip, take);
        Task GetIncompletedAsync(skip, take);
    }
}