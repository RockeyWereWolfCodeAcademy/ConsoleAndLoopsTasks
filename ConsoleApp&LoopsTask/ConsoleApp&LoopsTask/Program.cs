
namespace ConsoleApp_LoopsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //int[] nums = { 0, 0, 1, 1, 49, 5787, 6666, 77, 77, 1, 49 };
            //int count = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
                
            //    count = 0;
            //    //check if the element at index i has been duplicated before
            //    bool isDuplicated = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            isDuplicated = true;
            //            break;
            //        }
            //    }
            //    if (isDuplicated)
            //    {
            //        continue;
            //    }
                
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            count++;
            //        }
            //    }

            //    Console.WriteLine(nums[i] + " -> " + count);
            //}
            //task 2
            //Console.Write("Enter the size of the array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //if (size <= 0)
            //{
            //    Console.WriteLine("Array size must be greater than 0. Exiting...");
            //} 
            //else
            //{
            //    int[] array = new int[size];
            //    int currentIndex = 0;

            //    Console.Write("Do you want to enter elements to the array (Yes/yes/Y/y)? ");
            //    string response = Console.ReadLine();

            //    if (response == "Yes" || response == "yes" || response == "Y" || response == "y")
            //    {
            //        while (currentIndex < size)
            //        {
            //            Console.Write("Enter element №"+ (currentIndex + 1)+": ");
            //            int element = Convert.ToInt32(Console.ReadLine());
            //            array[currentIndex] = element;
            //            currentIndex++;
            //            if (currentIndex < size)
            //            {
            //                Console.Write("Do you want to enter next element (Yes/yes/Y/y)? ");
            //                response = Console.ReadLine();
            //                if (!(response == "Yes" || response == "yes" || response == "Y" || response == "y"))
            //                    break;
            //            }
            //        }

            //        Console.WriteLine("Array elements:");
            //        for (int i = 0; i < currentIndex; i++)//output only this elements which were entered earlier
            //        {
            //            Console.WriteLine(array[i]);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Array input canceled. Exiting...");
            //    }
            //}
        }
    }
}