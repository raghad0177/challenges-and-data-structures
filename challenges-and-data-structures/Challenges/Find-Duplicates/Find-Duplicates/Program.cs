namespace Find_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] duplicate = new int[12] { 1, 1, 2, 3, 4, 5, 6, 7, 7, 8, 7, 9 };
            int[] duplicateResult = FindDuplicates(duplicate);
            Console.WriteLine("Duplicates: " + string.Join(", ", duplicateResult));
        }
          
        public static int[] FindDuplicates(int[] duplicate)
        {
            int count = 0;
            int[] result = new int[duplicate.Length];
            for (int i = 0; i < duplicate.Length; i++)
            {
                bool isAlreadyAdded = false;
                for (int j = i + 1; j < duplicate.Length; j++)
                {
                    if (duplicate[i] == duplicate[j])
                    {
                        for (int k = 0; k < count; k++)
                        {
                            if (result[k] == duplicate[i])
                            {
                                isAlreadyAdded = true;
                                break;
                            }
                        }
                        if (!isAlreadyAdded)
                        {
                            result[count] = duplicate[i];
                            count++;
                        }
                    }
                }
            }
            int[] finalResult = new int[count];
            for (int i = 0; i < finalResult.Length; i++)
            {
                finalResult[i] = result[i];
            }
            return finalResult;
        }
    }
}
