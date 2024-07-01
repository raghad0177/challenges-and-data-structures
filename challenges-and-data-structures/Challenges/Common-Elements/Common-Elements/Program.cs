namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 5, 6 };
            int[] restult = CommonElements(arr1, arr2);
            for (int i = 0; i < restult.Length; i++)
            {
                Console.WriteLine(restult[i]);
            }  
        }



        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            int maxLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
            int[] arr3 = new int[maxLength];
            int count = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        bool alreadyExists = false;
                        for (int k = 0; k < arr3.Length; k++)
                        {
                            if (arr1[i] == arr3[k])
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                        if (!alreadyExists)
                        {
                            arr3[count] = arr1[i];
                            count++;
                        }
                    }
                }
            }


            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = arr3[i];
            }

            return result;
        }
    }
}
