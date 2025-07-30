using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using schoolBL;

namespace SchoolApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            schoolBL = new schoolBL.schoolBL();
            schoolBL.FillTablesFromXml();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentsWindow studentsWindow = new StudentsWindow();
            studentsWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TeachersWindow teacherWindow = new TeachersWindow();
            teacherWindow.Show();
        }
        schoolBL.schoolBL schoolBL;

    }
}