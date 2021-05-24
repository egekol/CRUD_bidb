using System;

namespace Constructor_ve_Encapsulation
{

    class human //class: bir kavramı belirtir
    {
        public human()
        {
            Console.WriteLine("New human object has been created.");
        }



        public String name; //her insanın bir ismi vardır, bu onun özelliğidir.
        //!! int weight = 80; //class içinde belirlenmesi kavramdaki her insanın sabit kiloya denk gelmesi demektir
        public int weight;
        //*** bir değişkenin public halde tutlması tercih edilmez. Bu sebeple encapsualiton ile getter/ setter fonksiyonlarını kullanırız
        private int _height;

        public int Height //aşağıda oluşturduğumuz getter setter fonksiyonları yerine csharpta böyle bir kolaylık yapabiliriz.
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                    this._height = -1 * value; //hata da yazdırabilirdik
                else
                    this._height = value;
            }
        }
        //AŞAĞIDAKİ FONKSİYON YERİNE YUKARIDA GET/SET YAZDIK
        //public void setHeight (int height)//niye get set yaptık? Niye private hale çevirdik? Kontrollerin ve yetkilerin bizim elimizde olması için.
        //{                                 //Örn. boyunun eksi verilmesini istemeyiz.
        //    if (height < 0)
        //        this._height = -1* height; //hata da yazdırabilirdik
        //    else
        //        this._height = height;
        //}
        //public int getHeight()  
        //{                       
        //    return _height;  
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            human ali = new human(); //yeni obje ürettik
            ali.name = "ali demir";
            ali.weight = 80;
            //ali.setHeight(170); BUNUN YERİNE:
            ali.Height = 170;

            human veli = new human();
            veli.weight = 70;
            Console.WriteLine("Youtube: Bilgisayar Kavramları");
            Console.WriteLine("Ali'nin boyu : " + ali.Height);

            //eğer set edilen değer eksi olsaydI?
            //ali.setHeight(-170); BUNUN YERİNE:
            ali.Height = -170;


            Console.WriteLine("Ali'nin boyu : " + ali.Height);


        }
    }
}
