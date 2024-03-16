namespace AylinToDo.Services
{  
    public interface IToDoService
    {
        public void Add(ToDoItems item);

        public IEnumerable<ToDoItems> GetAll();

        public void Delete(ToDoItems item);       

        public void Complete(ToDoItems item);

        public void Uncomplete(ToDoItems item);
    }
}
