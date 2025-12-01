namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --Todo App--");
            Console.WriteLine(" 1. Add Chore");
            Console.WriteLine(" 2. Remove Chore");
            Console.WriteLine(" 3. View Chores");
            Console.WriteLine(" 4. Exit");
            Console.Write(" Select an option: ");

            var option = Console.ReadLine();
            if (int.TryParse(option, out int num))
            {
                switch (num)
                {
                    case 1:
                        AddChore();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine(" Exiting...");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine(" Invalid option. Please enter a number.");
            }
        }

        static void AddChore()
        {
            Console.Clear();
            Console.WriteLine(" --Add Chore--");
            Console.Write("Enter Chore Description:");
            var choreName = Console.ReadLine();

        }

    }
}
