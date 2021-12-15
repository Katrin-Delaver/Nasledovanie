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
    /// Логика взаимодействия для AbirurientPage.xaml
    /// </summary>
    public partial class AbirurientPage : Page
    {
        List<Abiturient> abiturients;
        public AbirurientPage()
        {
            InitializeComponent();
            abiturients = new List<Abiturient>();
            abiturients.Add(new Abiturient(100, "Петр", "20-12-2000", "мужской"));
            dataAbiturient.ItemsSource = abiturients;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            abiturients.Add(new Abiturient(Convert.ToInt32(inputNumberCoints.Text), inputFIO.Text, inputDateOfBirth.Text, inputPol.Text));
            dataAbiturient.ItemsSource = abiturients;
            dataAbiturient.Items.Refresh();
        }

        private void Go(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PreobrazPage(abiturients));
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GoStudent(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentPage());
        }
    }
}
