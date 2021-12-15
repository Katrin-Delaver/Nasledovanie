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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nasledovanie
{
    /// <summary>
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        List<Student> students;
        public StudentPage()
        {
            InitializeComponent();
            students = new List<Student>();
            students.Add(new Student(3, "79", "CN", 100, "Лиза", "20-20-1999", "мужской"));
            dataStudent.ItemsSource = students;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            students.Add(new Student(Convert.ToInt32(inputNumberKyrs.Text), inputNumbeTeam.Text, inputNumbeFacultet.Text, Convert.ToInt32(inputNumberCoints.Text), inputFIO.Text,
                                     inputDateOfBirth.Text, inputPol.Text));
            dataStudent.ItemsSource = students;
            dataStudent.Items.Refresh();
        }
    }
}
