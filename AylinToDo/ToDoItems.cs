namespace AylinToDo
{
    public class ToDoItems
    {
        public ToDoItems(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public bool IsDone { get; set; }       
    }
}
