using System;

namespace Home.task1
{
    internal class Program
    {
        static void Main(string[] args)

        {
           Console.WriteLine("Adinizi daxil edin");
           string name = Console.ReadLine();

           Console.WriteLine("Soyadinizi daxil edin");
           string surname = Console.ReadLine();

           Console.WriteLine("Ata adini daxil edin");
           string fatherName = Console.ReadLine();

           Console.WriteLine("Cinsiyeti daxil edin");
           string gender = Console.ReadLine();

           string child = " ";
           if(gender == "man")
           {
                child = " oglu";
           }
           else
           {
                child = " qizi";
           }

            Console.WriteLine("Dogum Tarixinizi daxil edin(YALNIZ IL)");
            int birthday = int.Parse(Console.ReadLine());
            //indiki zaman 
            DateTime indikiVaxt = DateTime.Now;

            //menim ad gunum
            int age = indikiVaxt.Year - birthday;

           Console.WriteLine("Unvani  daxil edin");
           string adress = Console.ReadLine();

           Console.WriteLine(surname + " " + name + " " + fatherName  + child);
           Console.WriteLine(birthday + " Tarixinde  doguldugunuz ucun hal-hazirda " + age + " yasiniz var");

            int chilhhood;
            if (age > 0 && age < 11) 
            { 
                Console.WriteLine("Usaqliq dövrü yaşamaqdasınız");
            }
            if (age >11 && age < 16)
            {
                Console.WriteLine("Yeniyetmelik dövrü yaşamaqdasınız ");
            }
            if (age > 16 && age < 18)
            {
                Console.WriteLine("erkən gənclik dövrü yaşamaqdasınız ");
            }
            if (age > 18 && age < 35)
            {
                Console.WriteLine("gənclik dövrü yaşamaqdasınız ");
            }
            if (age > 35 && age < 65)
            {
                Console.WriteLine("orta yas dövrünü yaşamaqdasınız ");
            }
            if (age > 65 && age < 1500)
            {
                Console.WriteLine("qocalıq dövrünü yaşamaqdasınız ");
            }
            //qeyde alinib alinmaamgini bildiren if serti
            if (age > 18 && age < 35)
            {
                Console.WriteLine("Bu telebi nezere alraq sizin muracioetiniz qeyde alinmisdir");
            }
            else
            {
                Console.WriteLine("Bu telebi nezere alraq sizin muracietiniz qeyde alinmamisdir");
            }

            
        }
    }
}
