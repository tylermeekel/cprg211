namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 & 2
            Console.WriteLine("Task 1 & 2");
            Console.Write("Enter the lower number: ");
            int low = GetIntFromUser();
            while (low <= 0)
            {
                Console.WriteLine("Incorrect input, enter a positive number!");
                low = GetIntFromUser();
            }

            Console.Write("Enter the higher number: ");
            int high = GetIntFromUser();
            while (high <= low)
            {
                Console.WriteLine($"Incorrect input, enter a number higher than {low}");
                high = GetIntFromUser();
            }

            int diff = high - low;
            Console.WriteLine($"The difference between {high} and {low} is {diff}");

            // Task 3
            Console.WriteLine("Task 3");

            // Creating List and adding numbers from low to high
            List<int> nums = new List<int>();
            for (int i = low; i <= high; i++)
            {
                nums.Add(i);
            }

            // Writing to File
            using (StreamWriter sw = new StreamWriter("C:\\CPRG211\\file.txt"))
            {
                for (int i = nums.Count-1; i >= 0 ; i--)
                {
                    sw.WriteLine(nums[i]);
                }
            }
        }

        static int GetIntFromUser()
        {
            int num;
            while (true)
            {
                string numStr = Console.ReadLine();
                if (int.TryParse(numStr, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again.");
                }
            }

            return num;
        }
    }
}