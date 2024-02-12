using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using finalProjem; //2021112204

namespace finalProjem
{
    /// <summary>
    /// Interaction logic for LoginMemberScreen.xaml
    /// </summary>
    public partial class LoginMemberScreen : Window
    {
        public LoginMemberScreen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        static public string OnlineUserNameLogin; //2021112208

        private void txt_username_TextChanged(object sender, TextChangedEventArgs e)
        {
            string isim = txt_username.Text;
            OnlineUserNameLogin = isim;
           }


        bool isThere;
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            string myUserName = txt_username.Text;
            string myPassword = txt_password.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Users", baglanti);
            SqlDataReader reader = komut.ExecuteReader(); //tablodaki tum degerleri okumak icin executereader yazdim

            while (reader.Read())
            {

                if (myUserName == reader["Username"].ToString() && myPassword == reader["Password"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }

            }

            if (isThere) 
            {
                MessageBox.Show("Succesful!");
                this.Close();
                CrawlerStartScreen crawlerStartS = new CrawlerStartScreen();
                crawlerStartS.ShowDialog(); //cant click mainwindow while open Login screen


            }
            else
            {
                MessageBox.Show("ERROR! Please check UserName and Password!");
            }
            baglanti.Close();
        }

       
    }
}
