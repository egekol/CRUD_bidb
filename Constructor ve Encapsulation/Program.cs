using System;

namespace Constructor_ve_Encapsulation
{

    class Human //class: bir kavramı belirtir
    {

        public int Age;
        public string Gender;
        public string Language;

        public Human(int personAge, string personGender, string personLanguage)// class constructor kullanarak çoklu parametre oluşturmayı sağlıyoruz.
        {
            Age = personAge;
            Gender = personGender;
            Language = personLanguage;
            Console.WriteLine("New human object has been created.");
        }



        public String Name; //her insanın bir ismi vardır, bu onun özelliğidir.
        //!! int weight = 80; //class içinde belirlenmesi kavramdaki her insanın sabit kiloya denk gelmesi demektir
        public int Weight;
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
                    this._height = -1 * value; //hata da yazdırabilirdik ** design patterns (singleton), dependancy injection
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

    class Depart : Human //inheritance
    {
        public string Department 
        {
            get;
            set;
        }

        public void Role () { Console.WriteLine("Department role has been given to user: " + Department); }

        public Depart(int personAge, string personGender, string PersonLanguage) : base(personAge, personGender, PersonLanguage)
        {

        }



    }

    class Program
    {
        static void Main(string[] args)
        {

            Human ali = new Human(15, "Male", "Turkish"); //yeni obje ürettik
            ali.Name = "ali demir";
            ali.Weight = 80;
            //ali.setHeight(170); BUNUN YERİNE:
            ali.Height = 170;


            Human veli = new Human(22, "Male", "French");
            veli.Weight = 70;
            Console.WriteLine("Youtube: Bilgisayar Kavramları");
            Console.WriteLine("Ali'nin boyu : " + ali.Height);
            Console.WriteLine("Veli: " + veli.Age + " " + veli.Gender + " " + veli.Language);
            //eğer set edilen değer eksi olsaydI?
            //ali.setHeight(-170); BUNUN YERİNE:
            ali.Height = -170;


            Console.WriteLine("Ali'nin boyu : " + ali.Height);



            Depart egeDepart = new Depart(21, "Male", "Turkish");

            egeDepart.Department = "Industrial Engineering";
            egeDepart.Role();

        }
    }


}
