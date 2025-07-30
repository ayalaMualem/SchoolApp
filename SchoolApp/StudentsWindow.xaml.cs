using schoolDAL.Models;
using System;
using schoolBL;
using Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.ComponentModel;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public StudentsWindow()
        {
            DataContext = this;

            schoolBL = new schoolBL.schoolBL();
            Students = schoolBL.GetStudents("All");
            Classes = new List<string>();
            Classes.Add("All");
            Classes.AddRange(schoolBL.GetClasses());
            InitializeComponent();
        }
        schoolBL.schoolBL schoolBL;
        public List<Student> Students {  get;  set; }
        public List<string> Classes { get; set; }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string selectedClass = comboBox.SelectedItem as string;
            //Students.Clear();
            //Students.AddRange(schoolBL.GetStudents(selectedClass));
            Students=schoolBL.GetStudents(selectedClass);
            OnPropertyChanged("Students");
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
