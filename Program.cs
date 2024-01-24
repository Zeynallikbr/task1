namespace Home.task1
{
    internal class Program
    {
        static void Main(string[] args)
          
        {
            string Man = " oglu";
            string Woman = " qizi";

            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin");
            string surname = Console.ReadLine();

            Console.WriteLine("Ata adini daxil edin");
            string fatherName = Console.ReadLine();

           /* if (fatherName == Man)
            {
                Console.WriteLine("oglu");
            }
            else
            {
                Console.WriteLine("qizi");
            }*/
            Console.WriteLine("Cinsiyeti daxil edin");
            string gender = Console.ReadLine();

            if(gender == Man)
            {
                Console.WriteLine(" oglu");
            }
            else
            {
                Console.WriteLine(" qizi");
            }
            Console.WriteLine("Dogum tarixini daxil edin");
            string Birthday = Console.ReadLine();


            Console.WriteLine("Unvani  daxil edin");
            string adress = Console.ReadLine();

            Console.WriteLine(name +" " + surname + " " + fatherName + gender);
           // Console.WriteLine(Birthday + " doğulduğunuz üçün hal-hazida 18 yasiniz var" );

        }
    }
}
