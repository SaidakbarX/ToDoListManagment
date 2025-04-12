using ToDoList.DAL.Entity;

namespace ToDoList.Repository.Services
{
    public interface IToDoItemRepository
    {
        Task<long> InsertToDoItemAsync(long id);
        Task DeleteToDoItemByIdAsync(long id);
        Task<ToDoItem> UpdateToDoItemAsync(ToDoItem item);
        Task<List<ToDoItem>> SelectAllToDoItemsAsync(int skip, int take)
 SelectToDoItemByIdAsync()
 SelectByDueDateAsync
 SelectCompletedAsync(skip, take)
            SelectIncompleteAsync(skip, take)
    }
}