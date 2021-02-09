namespace TwoSum
{
    class Program
    {
        static int Target = 6;
        static string Result;
        static int[] Inputarray = { 1, 2, 3, 4, 5, 6 };
        static void Main(string[] args)
        {           
            FindTarget(Inputarray);
        }

        static string FindTarget(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == Target)
                    {                        
                        Result = i.ToString() + " ," + j.ToString();
                    }
                }
            }

            return Result;
        }
    }
}
