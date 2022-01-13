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
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Todo todo;

        public EditWindow()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            // TODO : update in db

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
