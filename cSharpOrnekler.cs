using System;

namespace console1
{
    class Program
    {
        static void Main( string[] args )
        {
            /* int onay;
           for (int i = 1; i <= 9; i++)
             {
                for (int j = 1; j <= 9; j++)
                 {
                     Console.WriteLine(i+j);
                 }if ((i * i) + (4 * j) == (j * j) + (4 * i)) 
                 {
                     ++onay;
                     Console.WriteLine();
                 }
             }

             Console.ReadKey();



             for ( int i = 1 ; i <= 9 ; i++ )
             {
                 for ( int j = 0 ; j <= 9 ; j++ )
                 {
                     if ( (i*i) + (4*j) == (j*j) + (4*i) )
                     {
                         Console.WriteLine(i + j);

                     }


                 }
             }
            */


            /*------------------------------------------------------------------------------*/

            // tek for çözüm ab sayısı ödevi
            /*double b, o, t1, t2;
            byte sayac = 0;
            for ( double i = 10 ; i <= 99 ; i++ )
            {
                b = i % 10;
                o = ( i - b ) / 10;
                t1 = b * b + 4 * o;
                t2 = o * b + 4 * b;

                if ( t1 == t2 )
                {
                    Console.WriteLine ( i );
                    sayac++;
                }

            }
            Console.WriteLine ( "eşitliğini sağlayan toplam ''{0}'' sayı vardır" , sayac );
            Console.ReadKey ( );
            */



            //çift for çözüm ab sayısı ödevi
            /*
            byte sayac = 0;
            for ( int o = 1 ; o <= 9 ; o++ )
            {
                for ( int b = 0 ; b <= 9 ; b++ ) 
                {
                    if ( ( o * o + 4 * b ) == ( b * b + 4 * o ) )
                    {
                        Console.WriteLine ( " {0}{1} ", o, b );
                        sayac++;
                    }
                }

            }
            Console.WriteLine ( " şarta uyan {0} sayı vardır " , sayac );
            Console.ReadKey();

         */
            /*------------------------------------------------------------------------------*/


            //n değeri dışarıdan girildiğinde s serisinin değerini hesaplayan program
            /*
            double n, s=1;

            Console.WriteLine ( "n degerini giriniz : " );
            n = Convert.ToDouble(Console.ReadLine());
            //s = (1+ 1/2 + 1/3 ... 1/n) * 5
            for ( double i = 1 ; i <= n ; i++ )
            {

                s = s + 1 / s;

            }

            s = s * 5;

            Console.WriteLine("sonuc = {0}", s);
            Console.ReadKey();
            */



            /*------------------------------------------------------------------------------*/


            //n değeri dışarıdan girildiğinde s serisinin değerini hesaplayan program
            //2.versiyon
            // e=(1+ 1/1! + 1/2! + 1/3!...+1/n!)
            /*
            double n, e = 1, f = 1;
            Console.WriteLine ( "n degerini giriniz : " );
            n = Convert.ToDouble( Console.ReadLine() );
            for ( int i = 1 ; i <=n ; i++ )
            {
                for ( int r = 1 ; r <= i ; r++ )
                {
                    f = f * r;
                }
                e += 1 / f;
            }
            Console.WriteLine ("sonuc = {0}", e);
            Console.ReadKey ( );
            */



            //-----------------------------------------------------------------------------------



            //FAKTÖRİYEL HESAPLAMA
            /*
            Console.Write ( " Lütfen Sayıyı Giriniz : " );
            double sayi = Convert.ToInt32 ( Console.ReadLine ( ) );
            double faktoriyel = 1;

            for ( int i = 1 ; i <= sayi ; i++ )
            {
                faktoriyel = faktoriyel * i;
            }

            Console.WriteLine ( "{0} sayısının faktöriyeli={1}" , sayi , faktoriyel );
            Console.ReadKey ( );

        }*/


            //-----------------------------------------------------------------------------------



            //S = ( 1+ 1/2 + 1/3 + ... + 1/n ) * 5
            /*double n, s=0;
            Console.WriteLine ( "lütfen n degerini giriniz : " );
             n= Convert.ToDouble( Console.ReadLine() );
            s= Convert.ToDouble( Console.ReadLine() );
            for( double i = 1; i <= n; i++ )
            {
                s += 1 / i;
            }
            s = s * 5;
            Console.WriteLine ( "sonuc = {0}" , s );
            //Console.WriteLine ( "sonuc =" + s );
            Console.ReadKey();
        */

            /*
            //E = (1 + 1/1! + 1/2! + 1/3! ... + 1/n!)
            double n, e =1, f =1;
            Console.WriteLine ( "lütfen n degerini giriniz : " );
            n = Convert.ToInt32( Console.ReadLine() );


            for ( double i = 1 ; i <=n ; i++ )
            {
                for ( double r = 1 ; r <= i ; r++ )
                {
                    f *= r;
                }
                e += 1 / f;
              //e = e + 1 / f;
            }
            Console.WriteLine ( "serinin sonucu = " + e );
            Console.ReadKey();
        */







            //--------------------------------------------------------------








            // kullanıcı adı ve şifre programları


            /*
            string ad, sifre;
            const string k_adı = "abc";
            const string k_sifre = "123";

            do
            {
                Console.WriteLine ( "kullanıcı adınızı giriniz : " );
                ad = Console.ReadLine ( );
                Console.WriteLine ( "şifrenizi giriniz : " );
                sifre = Console.ReadLine ( );

                if ( sifre != k_sifre || ad!=k_adı )
                {
                    Console.WriteLine ( "tekrar deneyiniz:" );
                }

            } while ( ad!=k_adı || sifre!=k_sifre );
            Console.WriteLine ( "Hoşgeldin " + k_adı);
            Console.ReadKey ();
            */






            /*        
                const string AD = "ciguli";
                const string SIFRE = "123";
                const int DENEME_HAKKI = 3;
                int deneme = 0;
                string girilenAd, girilenSifre;
                while (deneme < DENEME_HAKKI)
                {
                    Console.Write("Kullanıcı adı girin = ");
                    girilenAd = Console.ReadLine();
                    Console.Write("Şifreyi girin = ");
                    girilenSifre = Console.ReadLine();
                    if (girilenAd == AD && girilenSifre == SIFRE)
                    {
                        Console.WriteLine("Doğru kullanıcı adı ve şifre girdiniz.");
                        break; // while döngüsünden çık.
                    }
                    Console.WriteLine("Yanlış kullanıcı adı veya şifre girdiniz.");
                    deneme++;
                    Console.Write("Kalan hakkınız ");
                    Console.WriteLine(DENEME_HAKKI - deneme);
                }
                Console.WriteLine("Çıkmak için bir tuşa basın.");
                Console.ReadKey();

        */






            /*
                    string kul_adi = "aaa";
                    string sifre = "12345";

                    Console.WriteLine("Lütfen kullanıcı adınızı girin");
                    string kullaniciadi = Console.ReadLine();

                    Console.WriteLine("Lütfen kullanıcı şifrenizi girin");
                    string kullanici_sifre = Console.ReadLine();

                    if (kullaniciadi==kul_adi && kullanici_sifre==sifre )
                    {
                         Console.WriteLine("Hoşgeldiniz");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış");
                    }

                    Console.ReadLine();*/




            //-----------------------------------------------------------------------------------





            //Coninue ve break

            /*
            for ( int i = 0 ; i < 10 ; i++ )
            {
                if ( i == 5 )
                {
                    continue;
                }
                Console.WriteLine ( i );
            }
            Console.ReadKey ( );
            */




            //-----------------------------------------------------------------------------------






            //kendisi hariç tüm bölenlerinin toplamı
            //kendisine eşit olan sayılara 
            //mükemmel sayı denir
            //verilen sayının mükemmel sayı
            //olup olmadığına bakan programı yazınız.
            //örnek sayı 6;
            // 3+2+1=6 


            //kod1
            /*
            Console.WriteLine ( "Sayı giriniz" );
            int sayi = Convert.ToInt32 ( Console.ReadLine ( ) );
            int toplam = 0;
            for ( int i = 1 ; i < sayi ; i++ )
            {
                if ( sayi % i == 0 )
                {
                    toplam = toplam + i;
                }
            }
            if ( toplam == sayi )
            {
                Console.WriteLine ( sayi + "sayı Mükemmel Sayıdır" );
            }
            else
            {
                Console.WriteLine ( sayi + "sayı Mükemmel Sayı Değildir" );
            }
            Console.ReadLine ( );
            */




            //kod2
            /*
            int n, toplam = 0;
            Console.WriteLine ( "sayı giriniz: " );
            n = Convert.ToInt32 ( Console.ReadLine ( ) );
            for ( int i = 1 ; i < n ; i++ )
            {
                if ( n % i == 0 )
                {
                    Console.Write ( i + " " );
                    toplam = toplam + i;
                }
            }
            if ( toplam == n )
            {
                Console.WriteLine ( "mükemmel sayı" );
            }
            else
            {
                Console.WriteLine ( "değil" );
            }
            Console.ReadKey ( );
            */




            //-----------------------------------------------------------------------------------








            //uygulama : 
            //klavyeden girilen 0 dan farklı 
            //pozitif bir tamsayının "faktorien" olmadığını
            //test eden program.
            //"faktorian" =
            //hanelerinin faktöriyellerinin toplamı
            //kendisine eşit olan doğal sayılara denir.
            //ör: 145 sayısı?
            // 1! + 4! + 5! = 145 bir "faktorian" dir
            






            //-----------------------------------------------------------------------------------



            //subString degiskenini dizilerde kullanma/ dizi olarak kullanma
            /*
            string degisken = "123456";
            for ( int i = 0; i < 6; i++ )
            {
            //degisken.Substring(kaçtan başlasın, kaç basamak koplayaıp yazdırsın)
            Console.WriteLine( degisken.Substring(i,1) );
            }
            Console.ReadKey();
            */


            //-----------------------------------------------------------------------------------

            //DİZİ TANIMLAMA YÖNTEMLERİ


            //haftanın günlerini tutan dizi değişken
            // 7 tane günü ayrı ayrı string değişken tanımlamak yerine şöyle yapıyoruz:

            //string "[]" yaptığımızda derleyiciye dizi olduğunu tanımlıyoruz
            // iki alt yolla yapabiliriz:

            //1.alt yol:
            /*string[] dizi = new string[7];       // kaç elemandan oluştuğunu tanımlıyoruz
            dizi[0] = "Pazartesi";//0. indeksine git ve pazartesi yaz demek
            dizi[1] = "salı";
            dizi[2] = "çarşamba";
            dizi[3] = "perşembe";
            dizi[4] = "cuma";
            dizi[5] = "cumartesi";
            dizi[6] = "pazar";
            */

            //2. alt yol:
            // string[]dizi = { "pazartesi, salı, çarşamba, perşembe, cuma, cumartesi, pazar"}



            //-----------------------------------------------------------------------------------



            //DİZİ TANIMLAMA YÖNTEMLERİ _2

            //haftanın günlerinden(7) rastgele seçip yazdırma
            //rand fonksiyonların c# kullanımının başlangıcı
            /*
            string[] dizi = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            //denk geldikleri sayılar =     "0"  ,  "1"  ,  "2"     ,   "3"      ,  "4"  ,     "5"    ,    "6"        

            Random gün = new Random ( );
            int x = gün.Next ( 6 );  //6 ya kadar rastgele bir sayı üret dedik
            Console.WriteLine ( x );
            Console.WriteLine ( dizi[x] );  //dizi "x"(bizim seçtiğimiz değiken ismi)'i ekranda yazdır
            Console.ReadKey(); 
            */




            //-----------------------------------------------------------------------------------


            //DİZİ TANIMLAMA YÖNTEMLERİ _3-1



            //sınıf mevcudu 5 kişi olan bir sınıfın
            //vize notlarını 
            //bir dizi değişkende tutup
            //sınıf ortalamasını hesaplatan program
            /*
            byte[] notlar = new byte[5];
            double ortalama = 0;
            for ( int i = 0 ; i < 5 ; i++ )
            {
                Console.Write ( "{0}. öğrenci notunu giriniz : ", i+1 );
                notlar [ i ] = Convert.ToByte( Console.ReadLine() );
                ortalama += notlar [i];
            }
            ortalama = ortalama / 5;
            Console.WriteLine ("sınıf ortalaması = {0}", ortalama );
            Console.ReadKey ( );
            */





            //-----------------------------------------------------------------------------------


            //DİZİ TANIMLAMA YÖNTEMLERİ _3-2



            //sınıf mevcudu 5 kişi olan bir sınıfın
            //vize notlarını 
            //bir dizi değişkende tutup
            //sınıf ortalamasını hesaplatan program

            //ortalamadn yüksek kaç kişi olduğunu yazdır
            /*
            byte[] notlar = new byte[5];
            double ortalama = 0;
            byte sayac = 0;
            for ( int i = 0 ; i < 5 ; i++ )
            {
                Console.Write ( "{0}. öğrenci notunu giriniz : " , i + 1 );
                notlar[i] = Convert.ToByte ( Console.ReadLine ( ) );
                ortalama += notlar[i];
            }
            ortalama = ortalama / 5;
            for ( int i = 0 ; i < 5 ; i++ )
            {
                if ( notlar[i] > ortalama )
                {
                    sayac++;
                }
            }
            Console.WriteLine ( "sınıf ortalaması = {0}" , ortalama );
            Console.WriteLine ( "ortalamanın üzerinde {0} tane not vardır" , sayac );
            Console.ReadKey ( );
            */




            //-----------------------------------------------------------------------------------

            //DİZİ TANIMLAMA YÖNTEMLERİ _3-2  +   FOREACH DÖNGÜSÜ


            //foreach yöntemi yalnızca dizilerde kullanılabilir
            /*
            byte[] notlar = new byte[5];
            double ortalama = 0;
            byte sayac = 0;
            for ( int i = 0 ; i < 5 ; i++ )
            {
                Console.Write ( "{0}. öğrenci notunu giriniz : " , i + 1 );
                notlar[i] = Convert.ToByte ( Console.ReadLine ( ) );
                ortalama += notlar[i];
            }
            ortalama = ortalama / 5;
            foreach ( byte i in notlar )    //Burada i değişkenine dizinin elemanmlarını tek tek 0'dan başlatıp sonuna kadar, tek tek üzerine çekecek
            {
                if ( i > ortalama )
                {
                    sayac++;
                }
            }


            Console.WriteLine ( "sınıf ortalaması = {0}" , ortalama );
            Console.WriteLine ( "ortalamanın üzerinde {0} tane not vardır" , sayac );
            Console.ReadKey ( );
            */




            //-----------------------------------------------------------------------------------

            //FOREACH 1
            /*
            string[] ogrenciler = { "Ali" , "Ayşe" , "Elif" , "Fatma" };
            foreach ( string a in ogrenciler )
            {
                Console.WriteLine ( a );
            }
            Console.ReadKey();
            */

            /*


             //-----------------------------------------------------------------------------------


    public static void Main()
    {
        const string k_adı = "abc";
        string kadı = Convert.ToString ( k_adı );
        Console.WriteLine ( "kullanıcı adı giriniz : " );
        kadı = Console.ReadLine ( );



        const string p_parola = "213";
        string parola = Convert.ToString ( p_parola );
        Console.WriteLine ( "Lütfen şifre giriniz : " );
        parola = Console.ReadLine ( );



        if ( parola == p_parola && kadı == k_adı )
        {


            int secim;
            Console.WriteLine ( "giris basarili!" );


            Console.WriteLine ( "Lütfen işlem giriniz :\n1-hesap makinesi " );
            secim = Convert.ToInt32 ( Console.ReadLine ( ) );
            switch ( secim )
            {
                case 1:
                    Hesap ( );
                    break;

                default:

                    break;

            }



        }
        else
        {
            Console.WriteLine ( "tekrar deneyiniz." );
            Main ( );
        }

    }
    public static void Hesap()
    {
        float sayi1, sonuc, sayi2, secim;

        int secim2;
        Console.WriteLine ( "Yapmak istediğiniz işlemi seçiniz :\n1-toplama\n2-çıkarma\n3-çarpma\n4-bölme " );
        secim2 = Convert.ToInt32 ( Console.ReadLine ( ) );


        switch ( secim2 )
        {


            case 1:


                Console.Write ( "İşlem yapmak istediğiniz birinci sayiyi giriniz :  " );
                sayi1 = Convert.ToInt32 ( Console.ReadLine ( ) );
                Console.Write ( "İşlem yapmak istediğiniz ikinci sayıyı giriniz : " );
                sayi2 = Convert.ToInt32 ( Console.ReadLine ( ) );
                sonuc = sayi1 + sayi2;
                Console.Write ( "sonuc = {0} " , sonuc );
                Console.Write ( "Başka işlem yapmak ister misiniz?\t(1 = evet/2 = hayır)" );
                secim = Convert.ToInt32 ( ( Console.ReadLine ( ) );
                if ( secim == 1 )
                {
                    Console.WriteLine ( "" );
                }

                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            default:
                break;

        }

    }*/
            //-----------------------------------------------------------------------------------

            /*

            string[] ogrenciler = { "ali" , "ayşe" , "Ahmet" , "" };
            ogrenciler[3] = "Elif";

            for ( int i = 0 ; i < 4 ; i++ )
            {
                Console.Write ( ogrenciler[i] + " " );
            }
            Console.WriteLine("for döngüsü bitti");    

            int x = 0;
            do
            {
                Console.Write( ogrenciler [x] + " " );
                x++;

            }while ( x < 4 );
             Console.WriteLine("do döngüsü bitti");

            int y = 0;
            while( y < 4 )
            {
                Console.WriteLine ( ogrenciler[y] + " " );
                y++;
            }
            Console.WriteLine ( "while döngüsü bitti" );

            foreach( string icerik in ogrenciler )
            {
                Console.Write ( icerik + " " );
            }
            Console.WriteLine("foreach döngüsü bitti" );

            Console.ReadKey ( );

             */

            //-----------------------------------------------------------------------------------


            /*
            //n degerini girince
            //n degerine kadar olan tek ve çift sayıları ayrı ayrı toplayıp yazdırcak
            //kaç tane tek ve kaç tane çift sayı olduğunu yazdır
            //çiftlerin ve teklerin ortalaması buluncak

            int n, ciftAdet = 0, ciftToplam = 0, tekAdet = 0, tekToplam = 0;
            Console.Write ( "n degerini giriniz : " );

            n = Convert.ToInt32( Console.ReadLine() );

            int [] dizi= new int[n];

            for ( int i = 0 ; i < n ; i++ )
            {
                Console.Write ( "dizi[{0}] giriniz" , i );
                dizi[i] = Convert.ToInt32 ( Console.ReadLine ( ) );


                if ( dizi[i] % 2 == 0 )
                {
                    ciftAdet++;
                    ciftToplam += dizi[i];
                }
                else
                {
                    tekAdet++;
                    tekToplam += dizi[i];
                }

                Console.WriteLine ( "çift sayiların toplami = {0} " , ciftToplam );
                Console.WriteLine ( "çift sayıların adedi = {0}" , ciftAdet );
                if(ciftAdet != 0 ) 
                {
                    Console.WriteLine ( "çift sayıların ortalması = {0}" , ciftToplam / ciftAdet ); 
                }




                Console.WriteLine ( "tek sayıların toplamı = {0}" , tekToplam );
                Console.WriteLine ("tek sayıların adeti = {0}", tekAdet );

                if(tekAdet != 0 )
                {
                    Console.WriteLine ( "tek sayıların ortalaması = {0}" , tekToplam / tekAdet );

                }


                Console.ReadKey ( );
                */



            //-----------------------------------------------------------------------------------

            /*Örnek1: 0 -100 arasında girilen bir santigrat türünden sıcaklığın fahrenhayt
              karşılığını veren program.
              F= C x1.8+32;*/
            /*
             double f, c;
             Console.Write("Sıcaklık değerini girin");
             c = Convert.ToDouble(Console.ReadLine());
             f = c * 1.8 + 32;
             Console.WriteLine(f);
             Console.ReadKey();
            */
            //-----------------------------------------------------------------------------------
            /*
            Kullanıcı tarafından belirlenen bir sayının sonunda kaç sıfır olduğunu
            bulan program
            */
            /*
            int sayı, sayac = 0;
            Console.Write("sayıyı girin: ");
            sayı = Convert.ToInt32(Console.ReadLine());
            while (sayı % 10 == 0)
            {
            sayac = sayac + 1;
            sayı = sayı / 10;
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
            */
            //-----------------------------------------------------------------------------------
            /*
            Klavyeden girilen satır sayısına göre aşağıdaki üçgeni oluşturan
            program.
            */

            /*
            byte n;
            Console.Write("n değerini girin: ");
            n = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
            for (int r = 1; r <=i; r++)
            {
            Console.Write(r + " ");
            }
            Console.WriteLine();
            }
            Console.ReadKey();
             */
            //-----------------------------------------------------------------------------------
            /*
            Bilgisayar 1- 49 arası rastgele 5 tane tamsayı üretmektedir.
            Kullanıcının 1-49 arası girdiği 5 tahminden kaçının doğru olduğunu veren
            program.
            */

            /*
            int[] rastgele = new int[5];
            int[] tahmin = new int[5];
            Random rnd = new Random();
            byte sayac = 0;
            for (int i = 0; i < 5; i++)
            {
            rastgele[i] = rnd.Next(1,49);
            Console.Write("1- 49 arasında {0}. tahmini girin: ",i);
            tahmin[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
            for (int r = 0; r < 5; r++)
            {
            if (tahmin[i] == rastgele[r])
            sayac++;
            }
            }
            Console.WriteLine("{0} tane doğru tahmin", sayac);
            Console.ReadKey();
             */
            //-----------------------------------------------------------------------------------
            /*
            Klavyeden girilen NxN tipindeki A matrisinin en büyük ve en küçük
            elemanlarını ve bu elemanların yerlerini bulup sonuçları ekrana yazdıran
            program.
            */

            /*
            int N, enk, enb, bx, by, kx, ky;
            Console.Write("N değerini girin: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[N, N];
            for ( int i = 0 ; i < N ; i++ )
            {
                for ( int r = 0 ; r < N ; r++ )
                {
                    Console.WriteLine ( "matris[{0},{1}] değerini girin: " , i , r );
                    matris[i , r] = Convert.ToInt32 ( Console.ReadLine ( ) );
                }
            }
            enk = matris[0, 0];
            kx = 0;
            ky = 0;
            enb = matris[0, 0];
            by = 0;
            bx = 0;
            for ( int i = 0 ; i < N ; i++ )
            {
                for ( int r = 0 ; r < N ; r++ )
                {
                    if ( matris[i , r] < enk )
                    {
                        enk = matris[i , r];
                        kx = i;
                        ky = r;
                    }
                    if ( matris[i , r] > enb )
                    {
                        enb = matris[i , r];
                        bx = i;
                        by = r;
                    }
                }
            }
            Console.WriteLine("en küçük={0}, {1}. satır, {2}. sütun", enk, kx,ky);
            Console.WriteLine("en büyük={0}, {1}. satır, {2}. sütun", enb, bx,by);
            Console.ReadKey();
            */

            //-----------------------------------------------------------------------------------

            //Kendisine parametre olarak gönderilen bir metini şifreleyen metot
            /*
            string metin1;
            Console.Write ( "şifrelenecek metni girin: " );
            metin1 = Console.ReadLine ( );
            Console.WriteLine ( Sifrele ( metin1 ) );
            Console.ReadKey ( );
            static string Sifrele( string metin )
            {
                char[] ünlüler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u','ü' };
                foreach ( char eleman in ünlüler )
                {
                    metin = metin.Replace ( eleman , '*' );
                }
                metin = metin.Replace ( 'n' , '1' );
                return metin;
            }
            */
            

            //-----------------------------------------------------------------------------------

            //klavyeden girilen n adet sayının en büyüğünü ve en küçüğünü bulma
            /*
            Array sehirler = Array.CreateInstance ( typeof ( string ) , 10 );
            sehirler.SetValue ( "bolu" , 0 );
            sehirler.SetValue ( "urfa" , 1 );
            sehirler.SetValue ( "ankara" , 2 );
            sehirler.SetValue ( "istanbul" , 3 );
            sehirler.SetValue ( "van" , 4 );
            sehirler.SetValue ( "bursa" , 5 );
            sehirler.SetValue ( "konya" , 6 );
            sehirler.SetValue ( "bolu" , 7 );
            sehirler.SetValue ( "erzurum" , 8 );
            sehirler.SetValue ( "manisa" , 9 );
            //---------------------------------

            Console.WriteLine ( "şehirlerin sırasız hali\n " );
            foreach ( string sehirAdi in sehirler )
            {
                Console.Write ( sehirAdi + "\t " );
            }

            //---------------------------------
            Console.WriteLine ( "\n\nşehirlerin sıralı hali " );
            Array.Sort ( sehirler );//şehirleri sıralayarak ekrana yazdırıyoruz.
            foreach ( string sehirAdi in sehirler )
            {
                Console.WriteLine ( sehirAdi + "\t " );

            }
            */

            //-----------------------------------------------------------------------------------

            /* 

            Console.WriteLine ( "" );
            Array sayilar = Array.CreateInstance ( typeof ( Int32 ) , 10 );
            sayilar.SetValue ( 4, 0 );
            sayilar.SetValue ( 5 , 1 );
            sayilar.SetValue ( 7 , 2 );
            sayilar.SetValue ( 1 , 3 );
            sayilar.SetValue ( 2 , 4 );
            sayilar.SetValue ( 6 , 5 );
            sayilar.SetValue ( 3 , 6 );
            sayilar.SetValue ( 8 , 7 );
            sayilar.SetValue ( 9 , 8 );
            sayilar.SetValue ( 10 , 9 );

            Console.WriteLine ( "sayıların sıralanmamış hali " );
            foreach ( int sayi in sayilar )
            {
                Console.WriteLine ( sayi + "\t" );
            }

            Console.WriteLine ( "\nsayıların sıralanmış hali " );
            Array.Sort ( sayilar );
            foreach ( int sayi in sayilar )
            {
                Console.WriteLine ( sayi + "\t" );
            }
           */

            //-----------------------------------------------------------------------------------
            /*
            //n elemanı bir dizinin elemanlarının toplanması
            Console.WriteLine("n değerini giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int [n];
            int eleman, toplam = 0;
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.elemanın değerini giriniz : ",i+1 );
                eleman = Convert.ToInt32(Console.ReadLine());
                toplam += eleman;
            }   
            Console.WriteLine("{0} elemanlı dizinin elemanları toplamı = {1} ", n, toplam );

            */
            //-----------------------------------------------------------------------------------

     

            
            
            













        }
    }
}
