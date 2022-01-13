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
using System.Windows.Shapes;

namespace TodoList
{
    /// <summary>
    /// Logique d'interaction pour CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public Todo Todo { get; set; }

        public CreateWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Todo = new Todo()
            {
                Description = description.Text,
                Status = status.IsChecked,
                Id = null
            };
            // TODO : add to db
            // close window
            Close();
            // TODO : refetch db data
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
