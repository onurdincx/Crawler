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
    /// Interaction logic for AdminPanelScreen.xaml
    /// </summary>
    public partial class AdminPanelScreen : Window
    {
        public AdminPanelScreen()
        {
            InitializeComponent();
            getCrawledLinksVeri();
            getMembersVeri();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");
        DataSet daset = new DataSet();

        public void getCrawledLinksVeri()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from CrawledLinksDB2", baglanti);
            adtr.Fill(daset, "CrawledLinksDB2");
            crawled_datagrid.ItemsSource = daset.Tables["CrawledLinksDB2"].DefaultView;
            baglanti.Close();
        }

        public void getMembersVeri()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Users", baglanti);
            adtr.Fill(daset, "Users");
            member_datagrid.ItemsSource = daset.Tables["Users"].DefaultView;
            baglanti.Close();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_delete_member_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    var aaa = member_datagrid.SelectedItem;
                    var row = (DataRowView)aaa;

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete Users where Username=@Username", baglanti);
                    komut.Parameters.AddWithValue("@Username", row.Row.ItemArray[0]);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Deleted.");
                    daset.Tables["Users"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9


                getMembersVeri();

                }
                catch (Exception)
                {
                    MessageBox.Show("Done.");
                };

            }

        private void Btn_delete_crawled_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var aaa = crawled_datagrid.SelectedItem;
                var row = (DataRowView)aaa;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete CrawledLinksDB2 where CrawledLink=@CrawledLink", baglanti);
                komut.Parameters.AddWithValue("@CrawledLink", row.Row.ItemArray[2]);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Deleted.");
                daset.Tables["CrawledLinksDB2"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9

                getCrawledLinksVeri();

            }
            catch (Exception)
            {
                MessageBox.Show("Done.");
            };
        }
    }
    }

