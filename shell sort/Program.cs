namespace shell_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32 (Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine($"element {i+1}");
                nums[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("these are your numbers");
            foreach (int i in nums) 
            {
               
                Console.Write(i+ " ");
                Console.WriteLine();
            }
            Console.WriteLine("these are the numbers after sorting");
            int[] res = ShellSort(nums);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", res));
            
        }

        public static int[] ShellSort(int[] nums) 
        {
            int N = nums.Length;

            for (int gap = N / 2; gap > 0; gap /= 2) 
            {
                for (int i = gap; i < N; i += 1) 
                {
                    int temp = nums[i];
                    int j;
                    for (j = i; j >= gap && nums[j - gap] > temp; j -= gap) 
                    {
                        nums[j] = nums[j - gap];
                       
                    }
                    nums[j] = temp;
                }
            }
            return nums;
        }
    }
}
