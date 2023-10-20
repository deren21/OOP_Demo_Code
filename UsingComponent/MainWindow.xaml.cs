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

using Newtonsoft.Json;

namespace UsingComponent
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

        public class Account
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Alamat { get; set; }
        }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            Account derenAccount = new Account { Name = "Deren Tanaphan", Email = "derentanaphan@mail.ugm.ac.id", Alamat = "Kutabumi, Tangerang" };
            string accountString = JsonConvert.SerializeObject(derenAccount, Newtonsoft.Json.Formatting.Indented);
            TextBlock.Text = accountString;
        }
    }
}
