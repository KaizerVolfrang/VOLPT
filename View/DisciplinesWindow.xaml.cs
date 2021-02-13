using Model;
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

namespace View
{
    /// <summary>
    /// Interaction logic for DisciplinesWindow.xaml
    /// </summary>
    public partial class DisciplinesWindow : Window
    {
        private JournalStorage _context;

        public DisciplinesWindow(JournalStorage context)
        {
            InitializeComponent();
            _context = context;
        }
        
        //public void ShowDisciplines()
        //{
        //    var disciplines = _context.Disciplines.ToList();
        //    disciplinesBox.ItemsSource = disciplines;
        //    disciplinesBox.SelectedItem = disciplines[0];
        //}

    }
}
