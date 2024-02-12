using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using myWorks; //i used class namespace  2021112204

namespace finalProjem
{
    /// <summary>
    /// Interaction logic for CrawlerStartScreen.xaml
    /// </summary>
    public partial class CrawlerStartScreen : Window
    {
        public CrawlerStartScreen()
        {
            InitializeComponent();
            getVeri();
            getCrawledLinksVeri();
            onlineusernamelbl.Content= (LoginMemberScreen.OnlineUserNameLogin); //online user's username
        }





        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQONTGU;Initial Catalog=finalProjem_Data;Integrated Security=True");


        DataSet daset = new DataSet();

        public void getCrawledLinksVeri ()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from CrawledLinksDB2", baglanti);
            adtr.Fill(daset, "CrawledLinksDB2");
            crawledlinks_datagrid.ItemsSource = daset.Tables["CrawledLinksDB2"].DefaultView;
            baglanti.Close();
        }


    public void getVeri() //https://www.yazilimkodlama.com/programlama/c-comboboxa-veri-cekme-sql-server/ yardım aldım
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM MyLinks";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combobx1.Items.Add(dr["Url"]);
            }
            baglanti.Close();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            {
               
                MyWork myWorks = new MyWork(); //We created myWorks object with MyWork class
                lstbox1.Items.Clear();
                myWorks.Source = combobx1.Text; //selected value send to source
                string url = myWorks.SendUrl(); //url degiskenine aldik
                HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();//htmlagilitypack ile htmlweb nesnesi olusturduk
                HtmlAgilityPack.HtmlDocument rootDocumentlink = website.Load(url);//htmlagilitypack ile rotdocumentlink degiskeni olusturduk
                var mylinks = rootDocumentlink.DocumentNode.SelectNodes("//a"); // a ya göre degisken aldik
                foreach (var link in mylinks) // mylinks ve linki döngü yaptık
                {
                    link.InnerText.Trim();//ltrim ile bosluklari sildim
                    string veri = link.Attributes["href"] != null ? link.Attributes["href"].Value : string.Empty; // 2021112234 boş olmayan linkleri topluyoruz
                    lstbox1.Items.Add(veri); //listboxa ekledikk
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into CrawledLinksDB2(Date,Owner,CrawledLink) values(@Date,@Owner,@CrawledLink)", baglanti);
                komut.Parameters.AddWithValue("@Date", DateTime.Now);
                komut.Parameters.AddWithValue("@CrawledLink", combobx1.SelectedItem);
                komut.Parameters.AddWithValue("@Owner", onlineusernamelbl.Content);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successful!");
                daset.Tables["CrawledLinksDB2"].Clear(); //bunu eklemeseydim hep ustune ekleme yapiyodu 5 5+4 9
                getCrawledLinksVeri();
                
            }


        }

      
    }
}