using System.Collections.Generic;
using System.Windows;

namespace TodoList
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Todo> Todos;
        public MainWindow()
        {
            InitializeComponent();
            LoadTodos();
        }

        public void LoadTodos()
        {
            Todos = SqliteDbAccess.LoadTodos();
            todosList.ItemsSource = null;
            todosList.ItemsSource = Todos;
        }
        private void SelectEdit_Click(object sender, RoutedEventArgs e)
        {
            Todo selectedTodo = (sender as FrameworkElement).DataContext as Todo;
            EditWindow editWindow = new EditWindow(selectedTodo);
            _ = editWindow.ShowDialog();
            LoadTodos();
        }

        private void SelectDelete_Click(object sender, RoutedEventArgs e)
        {
            Todo selectedTodo = (sender as FrameworkElement).DataContext as Todo;
            DeleteWindow deleteWindow = new DeleteWindow(selectedTodo);
            _ = deleteWindow.ShowDialog();
            LoadTodos();
        }

        private void OpenCreateWindow_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            _ = createWindow.ShowDialog();
            LoadTodos();
        }
    }
}
