using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            todosList.ItemsSource = LoadCollectionData();
        }

        private List<Todo> LoadCollectionData()
        {
            List<Todo> todos = new List<Todo>
            {
                new Todo()
                {
                    Description = "Gagner la LFL",
                    Status = true,
                    Id = 1
                },

                new Todo()
                {
                    Description = "Gagner les EUM",
                    Status = true,
                    Id = 2
                },

                new Todo()
                {
                    Description = "Aller en LEC",
                    Status = false,
                    Id = 3
                },
                new Todo()
                {
                    Description = "Gagner la LEC",
                    Status = false,
                    Id = 4
                },
                new Todo()
                {
                    Description = "Aller au World",
                    Status = false,
                    Id = 5
                },
                new Todo()
                {
                    Description = "Gagner les World",
                    Status = false,
                    Id = 6
                }
            };

            return todos;
        }


        private void SelectEdit_Click(object sender, RoutedEventArgs e)
        {
            Todo selectedTodo = (sender as FrameworkElement).DataContext as Todo;
            EditWindow editWindow = new EditWindow
            {
                todo = selectedTodo
            };
            editWindow.description.Text = editWindow.todo.Description;
            editWindow.status.IsChecked = editWindow.todo.Status;
            _ = editWindow.ShowDialog();
            

        }

        private void SelectDelete_Click(object sender, RoutedEventArgs e)
        {
            Todo selectedTodo = (sender as FrameworkElement).DataContext as Todo;
            DeleteWindow deleteWindow = new DeleteWindow();
            deleteWindow.todo = selectedTodo;
            _ = deleteWindow.ShowDialog();
        }

        private void OpenCreateWindow_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            _ = createWindow.ShowDialog();
        }
    }
}
