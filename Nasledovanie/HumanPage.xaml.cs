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
    /// Логика взаимодействия для HumanPage.xaml
    /// </summary>
    public partial class HumanPage : Page
    {
        List<Human> humans;
        List<Teacher> teachers;
        public HumanPage()
        {
            InitializeComponent();
            humans = new List<Human>();
            humans.Add( new Human("Иванов Николай Васильевич", "20-01-2000", "мужской"));
            dataHuman.ItemsSource = humans;
            teachers = new List<Teacher>();
            teachers.Add(new Teacher("Учитель", "СИ", "Иванов Николай Васильевич", "20-01-2000", "мужской"));
            dataTeacher.ItemsSource = teachers;
        }

        private void GoAbiturient(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AbirurientPage());
        }

        private void AddTeacher(object sender, RoutedEventArgs e)
        {
            teachers.Add(new Teacher(inputFIOTeacher.Text, inputKafedra.Text, inputFIOTeacher.Text, inputDateOfBirthTeacher.Text, inputPolTeacher.Text));
            dataTeacher.ItemsSource = teachers;
            dataTeacher.Items.Refresh();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            humans.Add(new Human(inputFIO.Text, inputDateOfBirth.Text, inputPol.Text));
            dataHuman.ItemsSource = humans;
            dataHuman.Items.Refresh();
        }
    }
}
