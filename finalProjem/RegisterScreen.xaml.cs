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
    /// Interaction logic for RegisterScreen.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");


        private void txt_password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_register_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Users(Username,Password,MemberType) values(@Username,@Password,@MemberType)", baglanti);
            komut.Parameters.AddWithValue("@Username", txt_username.Text);
            komut.Parameters.AddWithValue("@Password", txt_password.Text);
            komut.Parameters.AddWithValue("@MemberType", combobox_MemberType.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registration Successful.");
        }

    }
}
