using System;
using System.Numerics;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace kriptoloji_proje
{
    public partial class form : Form
    {
        //RSA için gereken global değişkenler

        int p = 11, q = 127; //p ve q asal sayılarını tanımladık.
        int e = 107; //public key tanımlandı.
        int totient, n;


        public form()
        {
            InitializeComponent();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            totient = (p - 1) * (q - 1); // totient sayısı hesaplandı.
             n = p * q; // n base değerini bulduk.
        }

        private void BtnSfrle_Click(object sender, EventArgs e)
        {
          
                RSA_Encryption();
           
        }

        private void BtnCoz_Click(object sender, EventArgs e)
        {
           
                RSA_Decryption();
           
        }

        private void RSA_Encryption()
        {

            String metin = metin1.Text; //şifrelenecek metini aldık.
            String kriptometin="";

            for(int i = 0; i < metin.Length; i++) //metinin boyutu kadar döngü çalışacak
            {

                int sayi =Convert.ToInt32(metin[i]); //mesajın ilk indisi int yapıldı
                int kripto = (int)BigInteger.ModPow(sayi, e, n); // sayi^e mod n işlemi yapıldı
                kriptometin += Convert.ToChar(kripto); //kripto sayi char yapılıp kripto metine eklendi.

            }
            metin2.Text = kriptometin; //şifreli mesaj yazdırıldı.

        }


        private void RSA_Decryption()
        {
           
            String metin = metin1.Text; //çözülecek metini aldık.
            String cozulen_mesaj = "";
            int d = oklid_algorithm(); //uzatılmış oklid algoritması çağırıldı.
            for (int i = 0; i < metin.Length; i++) //metinin boyutu kadar döngü çalışacak
            {
                int sayi = Convert.ToInt32(metin[i]); //sifreli metinin ilk indisi int yapıldı
                int cozulen = (int)BigInteger.ModPow(sayi, d, n); //sayi^d mod n işlemi yapıldı
                cozulen_mesaj += Convert.ToChar(cozulen);//cozulen sayi cozulen mesaja eklendi
            }
            metin2.Text = cozulen_mesaj; //çözülen metin yazıldı
            
        }



        private int oklid_algorithm() //uzatıılmış öklid algoritması fonksiyonu.
        {
            int Q, x1=1, x2=0, x3=totient, y1=0, y2=1, y3=e, t1, t2, t3; //gerekli değişkenleri tanımladık.

            while (y3 != 1) // y3 degeri 1 değilken.
            {
              // uzatılmış öklid algoritmasının işlemleri yapılıyor
                Q = x3 / y3;
                t1 = x1 - (y1 * Q);
                t2 = x2 - (y2 * Q);
                t3 = x3 - (y3 * Q);
                x1 = y1;
                x2 = y2;
                x3 = y3;
                y1 = t1;
                y2 = t2;
                y3 = t3;
            }

            if (y2 < 0)
            {
                y2 += totient;
            }
            return y2;
        }
    }

}
