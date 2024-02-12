using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace finalProjem
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

        private void date(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            CultureInfo ci = new CultureInfo("tr-TR"); //2021112237
            timerLabel.Content = $"Today's date and time: {now.ToString("F", ci)}"; //F : full demek 2021112240 /timespan
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(); //2021112241 timer for wpf 
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += date;
            timer.Start();
        }

        private int increment = 0;

      



        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            LoginAdminScreen LoginAdminS = new LoginAdminScreen();
            LoginAdminS.ShowDialog(); //cant click mainwindow while open Login admin screen
        }


        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_EnterCrawler_Click(object sender, RoutedEventArgs e)
        {
            LoginMemberScreen myMemberScreen = new LoginMemberScreen();
            myMemberScreen.ShowDialog(); //cant click mainwindow while open login member screen
        }

        private void btn_EnterRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterScreen RegisterEntering = new RegisterScreen();
            RegisterEntering.ShowDialog(); //cant click mainwindow while open register screen
        }

        
    }
}
