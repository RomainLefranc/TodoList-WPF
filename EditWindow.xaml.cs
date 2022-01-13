using System.Windows;

namespace TodoList
{
    /// <summary>
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Todo todo;

        public EditWindow(Todo selectedTodo)
        {
            todo = selectedTodo;
            InitializeComponent();
            editTodoGrid.DataContext = todo;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //update in db
            SqliteDbAccess.UpdateTodo(todo);
            // close window
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
