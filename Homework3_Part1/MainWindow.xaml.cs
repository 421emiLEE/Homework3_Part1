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

namespace Homework3_Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String pigLatinFirstName;
            String pigLatinLastName;
            String firstName = fNametxt.Text; //Mark
            String lastName = lastNametxt.Text; //Aloka
            // length is 4 but we start at 0-3
            pigLatinFirstName = firstName.Substring(1,firstName.Length - 1) + firstName.Substring(0,1).ToLower() + "ay"; //arkmay
            pigLatinFirstName = pigLatinFirstName.Substring(0,1).ToUpper() + pigLatinFirstName.Substring(1,pigLatinFirstName.Length - 1);

            pigLatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1).ToLower() + "ay";
            pigLatinLastName = pigLatinLastName.Substring(0,1).ToUpper() + pigLatinLastName.Substring (1,pigLatinLastName.Length - 1);


            MessageBox.Show("Your name in Piglatin is : " + pigLatinFirstName + " " + pigLatinLastName);

        }
    }
}