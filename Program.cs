namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CheckAut();

        }

      
        public static void CheckAut()
        {
            do
            {
                Console.WriteLine("Istifadeci Adi Daxil Edin:");
                string username = Console.ReadLine();
                Console.WriteLine("Parol Daxil Edin:");
                string password = Console.ReadLine();

                if (username == "admin" && password == "12345")
                {
                    Console.WriteLine("Authed");
                    break;
                }
                else
                {
                    Console.WriteLine("Failed auth");
                }

            } while (true);
        }



    }
}