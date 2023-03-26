using CinemaProject.Business.Abstract;
using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.DataAccess;
using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Concrete
{
    internal class FilmManager : IFilmService
    {
        IFilmDal _filmDal;
        ICategoryDal _categoryDal;
        int _selectedCategoryNumber;
        public FilmManager(IFilmDal filmDal, ICategoryDal categoryDal, int selectedCategoryNumber)
        {
            _filmDal = filmDal;
            _categoryDal = categoryDal;
            _selectedCategoryNumber = selectedCategoryNumber;
        }
        public void Add()
        {

        }

        public int GetAll()
        {
            Stars.Show(48);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 VİZYONDAKİ FİLMLER");
            Stars.Show(48);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Console.ResetColor();
            Stars.Show(48);

            int r = 0;                                    //Burdaki değişken sayesinde film listesini sırasıyla yazdırmamı sağlıyor
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < 3; j++)
                {                                             //Burdaki kod fiyat listesinin daha düzgün çkması için yapıldı
                    int difference;
                    string gapLenght;
                    if (r < 9)                                // 9 dan küçük yapmamın sebebi, 9'dan sonra Id sayılar çift basamaklı olduğu için metin bi gıdım fazla çıkıyor
                    {
                        difference = 20 - _filmDal.GetAll()[r].Name.Length;
                        int l = 0;                             // l değişkeniyle differnce değerine kadar while döngüsünü döndürüyoruz
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    else                                        // 9 dan fazla olan Id sayılarının isim uzunluğunu 19'dan çıkardım
                    {
                        difference = 19 - _filmDal.GetAll()[r].Name.Length;
                        int l = 0;
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", _filmDal.GetAll()[r].Name, _filmDal.GetAll()[r].Price + " TL", gapLenght, "         ", _categoryDal.GetAll()[i].Name, r + 1);
                    r++;
                }

                Stars.Show(48);

            }
            Console.WriteLine();



            //Bu kısımda kategori seçimi yapılıyor
            byte selectedCategoryNumber = 0;
            bool x = true;
            while (x)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 ile 4 arasında bir Kategori Seçiniz");
                for (int i = 0; i < _categoryDal.GetAll().Count; i++)
                {
                    Console.WriteLine("\t{0} => {1} ", i + 1, _categoryDal.GetAll()[i].Name);
                }

                try
                {
                    selectedCategoryNumber = byte.Parse(Console.ReadLine());

                    if (selectedCategoryNumber <= _categoryDal.GetAll().Count && selectedCategoryNumber > 0)
                    {
                        x = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                        Console.ResetColor();
                        x = true;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    x = true;
                }
            }
            Console.Clear();


            return selectedCategoryNumber;
        }

        public int GetAllByCategoryId()
        {

            Stars.Show(48);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Stars.Show(48);
            Console.ResetColor();

            var temp1 = new List<Film>();

            int i = 0;
            while (i < _filmDal.GetAll().Count)
            {
                if (_filmDal.GetAll()[i].CategoryId == _categoryDal.GetAll()[_selectedCategoryNumber - 1].Id) //bu kısımda film listimde categori Id si ile categori listinde idleri eşit olan film listesini çağırdım
                {                                             //Burdaki kod fiyat listesinin daha düzgün çkması için yapıldı
                    int difference;
                    string gapLenght;
                    if (i < 9)                                // 9 dan küçük yapmamın sebebi, 9'dan sonra Id sayılar çift basamaklı olduğu için metin bi gıdım fazla çıkıyor
                    {
                        difference = 20 - _filmDal.GetAll()[i].Name.Length;
                        int l = 0;                             // l değişkeniyle differnce değerine kadar while döngüsünü döndürüyoruz
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    else                                        // 9 dan fazla olan Id sayılarının isim uzunluğunu 19'dan çıkardım
                    {
                        difference = 19 - _filmDal.GetAll()[i].Name.Length;
                        int l = 0;
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    temp1.Add(_filmDal.GetAll()[i]);//Geçici bir generic liste oluşturdum ve if koşulunu sağlayan elemankarı buraya attım ve try cact te kullandım                 

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", _filmDal.GetAll()[i].Name, _filmDal.GetAll()[i].Price + " TL", gapLenght, "         ", _categoryDal.GetAll()[_selectedCategoryNumber - 1].Name, i + 1);
                }
                i++;
            }
            Stars.Show(48);

            int selectedFilmNumber = 0;
            bool x = true;
            bool y = true;
            while (x)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("İzlemek istediğiniz Filmin No suna giriniz:");
                try
                {
                    selectedFilmNumber = int.Parse(Console.ReadLine());
                    y = true;
                    foreach (var item in temp1)
                    {
                        if (item.Id == selectedFilmNumber)
                        {
                            x = false;
                            break;//while döngüsü içindeki foreach yapısında break kullanıldığında sadece foareach yapısını durdurur ve while döngüsü herhangi bir şekilde etkilenmeden devam eder.
                        }
                        else
                        {
                            if (y)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Lütfen geçerli bir değer tuşlayınız");
                                Console.ResetColor();
                                y = false; //Burda bool y kullanmamın sebebi her defasında birden fazla geçerli değildir yazısını yazdırmaması içindir.
                            }

                            x = true;
                        }
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir değer tuşlayınız");
                    Console.ResetColor();
                    x = true;
                }
            }
            Console.ResetColor();
            Console.Clear();

            return selectedFilmNumber;
        }
    }
}
