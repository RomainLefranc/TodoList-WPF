using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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

            IHost host = Host.CreateDefaultBuilder().ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                configuration.Sources.Clear();

                IHostEnvironment env = hostingContext.HostingEnvironment;

                _ = configuration
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

                IConfigurationRoot configurationRoot = configuration.Build();
            })
            .Build();
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Todo selectedTodo = (sender as FrameworkElement).DataContext as Todo;
            CheckBox cb = sender as CheckBox;
            selectedTodo.Status = cb.IsChecked == true ? 1 : 0;
            SqliteDbAccess.UpdateTodo(selectedTodo);
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
