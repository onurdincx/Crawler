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

namespace finalProjem
{
    /// <summary>
    /// Interaction logic for LoginAdminScreen.xaml
    /// </summary>
    public partial class LoginAdminScreen : Window
    {
        public LoginAdminScreen()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        bool isThere;
        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            string adminName = txt_adminusername.Text;
            string adminPassword = txt_adminpassword.Text;
            string MemberType = txt_AdminRule.Text;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Users", baglanti);
            SqlDataReader reader = komut.ExecuteReader(); //tablodaki tum degerleri okumak icin executereader yazdim
                
            while (reader.Read())
            {

                if (adminName == reader["Username"].ToString() && adminPassword == reader["Password"].ToString() && MemberType == reader["MemberType"].ToString())
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
                Crawler CrawlerScreen = new Crawler();
                CrawlerScreen.ShowDialog(); //cant click mainwindow while open Login screen

            }
            else
            {
                MessageBox.Show("ERROR! Please check School Number and Password!");
            }
            baglanti.Close();

        }
    }

    }
