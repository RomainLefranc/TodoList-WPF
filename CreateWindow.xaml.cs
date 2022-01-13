using System.Windows;

namespace TodoList
{
    public partial class CreateWindow : Window
    {
        public Todo todo = new Todo();
        public CreateWindow()
        {
            InitializeComponent();
            addTodoGrid.DataContext = todo;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO : add to db
            SqliteDbAccess.SaveTodo(todo);
            // close window
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
