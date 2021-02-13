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
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private JournalStorage _context;
        public AuthorizationWindow(JournalStorage context)
        {
            InitializeComponent();
            _context = context;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GroupsWindow groupsWindow = new GroupsWindow(_context);
            UserControlService userControl = new UserControlService(_context);
            var login = loginBox.Text;
            var password = passwordBox.Text;
            if (userControl.SignIn(login, password))
            {
                Hide();
                groupsWindow.ShowDialog();
            }
        }

        
    }
}
