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
using Model;

namespace View
{
    /// <summary>
    /// Interaction logic for GroupsWindow.xaml
    /// </summary>
    public partial class GroupsWindow : Window
    {
        private JournalStorage _context;
        public GroupsWindow(JournalStorage context)
        {
            InitializeComponent();
            _context = context;

            var groups = _context.Groups.ToList();
            groupComboBox.ItemsSource = groups;
            groupComboBox.SelectedItem = groups[0];
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            var groups = _context.Groups.ToList();
            groupComboBox.ItemsSource = groups;
            groupComboBox.SelectedItem = groups[0];
            var disciplinesWindow = new DisciplinesWindow(_context);
            Hide();
            disciplinesWindow.ShowDialog();
        }
        
    }
}
