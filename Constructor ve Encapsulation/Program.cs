using System;
using System.Diagnostics;

namespace Constructor_ve_Encapsulation
{

    class Human //class: bir kavramı belirtir
    {

        public int Age;
        public string Gender;
        public string Language;

        public Human(int personAge, string personGender, string personLanguage) //class constructor kullanarak çoklu parametre oluşturmayı sağlıyoruz.
        {
            Age = personAge;
            Gender = personGender;
            Language = personLanguage;
            Console.WriteLine("New human object has been created.");
        }
        public void Building() //Polymorphism. Oluşturulan methodun aynısını diğer inherited classlarda kullanabiliyoruz. çağırırken aynı method ismini 
        //yazıyorsun fakat class'ın kendisine özel fonksiyonlar çalışıyor.
        {
            Console.WriteLine("Departmants have buildings.");
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
                   
                {
                    //Debug.Assert(false, "there is an error", "U fucked up the program dude...");
                    this._height = -1 * value; //hata da yazdırabilirdik ** design patterns (singleton), dependancy injection
                }
                else
                {
                    this._height = value;
                }            }
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

    abstract class Etik
    {
        // Abstract method (does not have a body)
        public abstract void Credit();
        // Regular method
        public void classPass()
        {
            Console.WriteLine("Every department has ethics lesson");
        }
    }

    class End : Etik
    {
        public override void Credit()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("3 credits of ethics lesson passed!");
        }
    }

    class IndustrialEngineer : Human //inheritance
    {
        public string Department 
        {
            get;
            set;
        }

        public void Role () { Console.WriteLine("Department role has been given to user: " + Department); }

        public IndustrialEngineer(int personAge, string personGender, string PersonLanguage) : base(personAge, personGender, PersonLanguage)
        {

        }

        public new void Building()
        {
            Console.WriteLine("Industrial Engineers has Maçka Building.");
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

            IndustrialEngineer ege = new IndustrialEngineer(21, "Male", "Turkish");

            ege.Department = "Industrial Engineering";
            ege.Role();
            ege.Building();
            
            veli.Building();

            //Abstraction
            End dersEnd = new End();
            dersEnd.classPass();
            dersEnd.Credit();
        }
    }


}
