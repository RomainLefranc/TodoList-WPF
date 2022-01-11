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
        public Todo todo;
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            todo = new Todo()
            {
                Description = description.Text,
                Status = status.IsChecked,
                Id = null
            };
            // add to db



            // close window
            // Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
