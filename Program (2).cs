using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string kullanıcıseçim = string.Empty;

            ArrayList arraydeger = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("MENÜ");
                Console.WriteLine("1-değer ekle:");
                Console.WriteLine("2-deger listele:");
                Console.WriteLine("3-değer ara:");
                Console.WriteLine("4-deger düzenle:");
                Console.WriteLine("5-deger sil:");
                Console.WriteLine("6-uygulama çıkış:");
                Console.WriteLine("------------Lütfen birini seç-------");
                kullanıcıseçim = Console.ReadLine();

                  switch(kullanıcıseçim)
                {
                    case ("1"):
                        Console.WriteLine("lütfen eklemek istediğiniz degeri giriniz");
                        string deger1 = Console.ReadLine();
                        arraydeger.Add(deger1);
                        Console.WriteLine("Eklemek istediğiniz deger başarıyla atandı");
                        System.Threading.Thread.Sleep(1100);
                    break;

                    case ("2"):
                        for (int sayaç = 0; sayaç < arraydeger.Count; sayaç++) 
                        {
                            Console.WriteLine("{0}.degeriniz={1}", sayaç, arraydeger[sayaç]);

                        }

                        Console.WriteLine("devam etmek için bir tuşa basınız");
                        Console.ReadLine();

                        break;

                    case ("3"):
                        {
                            Console.WriteLine("aramak istediğiniz değeri giriniz");
                            string aramadeger = Console.ReadLine();
                            bool aramadeger1 = arraydeger.Contains(aramadeger);

                            if(aramadeger1)
                            {
                                int intaranandeger = arraydeger.IndexOf(aramadeger);
                                string staramadeger = arraydeger[intaranandeger].ToString();
                                Console.WriteLine("{0}.değeriniz={1}", intaranandeger, staramadeger);
                                System.Threading.Thread.Sleep(3000);
                             }
             
                            else
                            {
                                Console.WriteLine("Girmiş Oldugunuz deger bulunamadı lütfen tekrar deneyiniz,DEVAM ETMEK İÇİN BİR TUŞA BASINIZ");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case ("4"):
                        Console.WriteLine("yeni oluşturmak istediğiniz değeri giriniz");
                         string degerdüzenleme = Console.ReadLine();

                        Console.WriteLine("{0} değerinizi hangi değer ile değiştirmek istiyorsunuz", degerdüzenleme);
                        string degerdüzenlemeyanıt = Console.ReadLine();

                        if(arraydeger.Contains(degerdüzenlemeyanıt))
                        {
                            int hedefindex = arraydeger.IndexOf(degerdüzenlemeyanıt);
                            arraydeger[hedefindex] = degerdüzenleme;
                            Console.WriteLine("güncellemek istdiğiniz değer başarıyla güncellendi");
                            System.Threading.Thread.Sleep(2000);

                        }
                        else
                        {
                            Console.WriteLine("Düzenlemek istediğiniz değer bulunamadı Lütfen tekrar deneyiniz");
                            Console.WriteLine("----Devam etmek için bir tuşa basınız----");
                            Console.ReadLine();

                        }

                        break;

                    case ("5"):
                        Console.WriteLine("Lütfen ekrana silmek istediğiniz değeri giriniz");
                        string silmedeger = Console.ReadLine();
                        
         
                        if(arraydeger.Contains(silmedeger))
                        {
                            int silinicekindex = arraydeger.IndexOf(silmedeger);
                            string silinicekdeger = arraydeger[silinicekindex].ToString();
                            arraydeger.Remove(silinicekdeger);

                            Console.WriteLine("{0}.degeriniz olan {1} değeri başarıyla silinmiştir.",silinicekindex,silinicekdeger);
                            System.Threading.Thread.Sleep(2000);
                        }

                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı Lütfen tekarar denemek için Menüye dönmek için bir tuşa basınız");
                            Console.ReadLine();
                        }

                        break;


                    case ("6"):
                        Console.WriteLine("Görüşmek üzere:))");
                        System.Threading.Thread.Sleep(2000);

                        break;



                    






                       
                }





               

            } while (kullanıcıseçim != "6");



            Console.ReadLine();



        }
    }
}
