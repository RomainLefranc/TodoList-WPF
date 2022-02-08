using System.Windows;
namespace TodoList
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public System.Collections.IList todos;
        public bool delete = false;

        public DeleteWindow(System.Collections.IList selectedTodos)
        {
            InitializeComponent();
            question.Content = "Voulez vous supprimez ce todo ?";
            if (selectedTodos.Count > 1)
            {
                question.Content = "Voulez vous supprimez ces todos ?";
            }
            todos = selectedTodos;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Todo todo in todos)
            {
                SqliteDbAccess.DeleteTodo(todo);
            }
            delete = true;
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
