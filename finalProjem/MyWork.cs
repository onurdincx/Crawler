using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWorks //2021112204
{
    class MyWork
    {
        public string Source { get; set; } //Adres isimli bir değişken tanımlıyoruz.

        public string SendUrl() //UrlGonder metodumuz.
        {
            return Source; //Adrese gelen veriyi geri gönder.
        }
    }
}
