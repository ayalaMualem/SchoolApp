using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using schoolBL;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public TeachersWindow()
        {
            InitializeComponent();
            DataContext = this;
            schoolBL = new schoolBL.schoolBL();
            Teachers = schoolBL.GetTeachers();

        }
        schoolBL.schoolBL schoolBL;
        public List<Teacher> Teachers { get; set; }
    }
}
