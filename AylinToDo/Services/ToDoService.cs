namespace AylinToDo.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IList<ToDoItems> _toDoItems;   

        public ToDoService()
        {
            _toDoItems = new List<ToDoItems> { 
            new ToDoItems("Çamaşırları Yıka"),
            new ToDoItems("Bulaşıkları Yıka")
            };
        }


        public void Add(ToDoItems item)
        {
            _toDoItems.Add(item);
        }

        public IEnumerable<ToDoItems> GetAll()
        {
            return _toDoItems.ToList();
        }

        public void Delete(ToDoItems item)
        {
            _toDoItems.Remove(item);
        }

        public void Complete(ToDoItems item)
        {
            item.IsDone = true;
        }

        public void Uncomplete(ToDoItems item)
        {
            item.IsDone = false;
        }

    }
}
