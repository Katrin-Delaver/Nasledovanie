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
    /// Логика взаимодействия для PreobrazPage.xaml
    /// </summary>
    public partial class PreobrazPage : Page
    {
        List<Abiturient> abiturients;
        List<Student> students;
        public PreobrazPage(List<Abiturient> abiturients)
        {
            InitializeComponent();
            this.abiturients = abiturients;
            dataAbiturient.ItemsSource = abiturients;

            students = new List<Student>();
        }

        private void Preobraz(object sender, RoutedEventArgs e)
        {
            Abiturient abiturient1 = dataAbiturient.SelectedItem as Abiturient;
            Abiturient abiturient2 = new Student(Convert.ToInt32(inputNumberKyrs.Text), inputNumbeTeam.Text,
                                                                    inputNumbeFacultet.Text, abiturient1.NumberCoints,
                                                                    abiturient1.Fio, abiturient1.DataOfBirth, abiturient1.Pol);

            Student student = (Student)abiturient2;
            students.Add(student);
            dataStudent.ItemsSource = students;
            dataStudent.Items.Refresh();
        }


        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
