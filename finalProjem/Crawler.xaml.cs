using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Crawler.xaml
    /// </summary>
    public partial class Crawler : Window
    {
        public Crawler()
        {
            InitializeComponent();
            ListUrlNow();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");

        DataSet daset = new DataSet();

        private void ListUrlNow()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from MyLinks", baglanti);
            adtr.Fill(daset, "MyLinks");
            lst_db_links.ItemsSource = daset.Tables["MyLinks"].DefaultView; 
            baglanti.Close();
        }



        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_ADD_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MyLinks(Name, Url) values(@Name,@Url)", baglanti);
            komut.Parameters.AddWithValue("@Name", txt_sitename.Text);
            komut.Parameters.AddWithValue("@Url", txt_Url.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Registration Successful.");
            txt_sitename.Clear();
            txt_Url.Clear();
            daset.Tables["MyLinks"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9
            ListUrlNow();

        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var aaa = lst_db_links.SelectedItem;
                var row = (DataRowView)aaa;


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete MyLinks where Name=@Name", baglanti);
                komut.Parameters.AddWithValue("@Name", row.Row.ItemArray[0]);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Deleted.");
                daset.Tables["MyLinks"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9
                ListUrlNow();

            }
            catch (Exception)
            {
                MessageBox.Show("Done.");
            };

        }

        private void Btn_adminpanel_Click(object sender, RoutedEventArgs e)
        {
            AdminPanelScreen myAdminPanelS = new AdminPanelScreen();
            myAdminPanelS.ShowDialog(); //cant click mainwindow while open Login screen
        }
    }

    }
