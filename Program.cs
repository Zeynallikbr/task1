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


           Console.WriteLine("Dogum tarixini daxil edin"));
           int birthday = Console.ReadLine();

            //dogum tarixi
            DateTime adgunum = new  DateTime(birthday);

            //indiki tarix 
            DateTime indikiTarix = DateTime.Now;

            //yas hesablama 
            int yas =indikiTarix.Year - adgunum.Year;

           Console.WriteLine("Unvani  daxil edin");
           string adress = Console.ReadLine();

           Console.WriteLine(surname + " " + name + " " + fatherName  + child);
           Console.WriteLine(birthday + " doguldugunuz ucun " + yas + "-iniz var" );


        }
    }
}
