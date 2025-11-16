using DataBlinding.Data;
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

namespace DataBlinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> Peiole { get; set; }
        Person person = new Person
        {
            Name = "Vlad",
            Age = 18
        };
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Denis", Age = 30},
            new Person{Name = "Anton", Age = 18},
            new Person{Name = "Vladimir", Age = 10},
            new Person{Name = "Stas", Age = 50},
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxNames.ItemsSource = People;
            //ListBoxNames.ItemsSource = new List<string>()
            //{
            //    "Denis",
            //    "Anton",
            //    "Vladimir",
            //    "Stas"
            //};
            //this.DataContext = person;
        }

        private void helloBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{person.Name} is {person.Age} years old.");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxNames.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}