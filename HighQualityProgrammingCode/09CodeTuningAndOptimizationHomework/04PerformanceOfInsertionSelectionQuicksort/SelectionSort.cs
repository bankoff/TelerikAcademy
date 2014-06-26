namespace _04PerformanceOfInsertionSelectionQuicksort
{
    public static class SelectionSort
    {
        public static int[] SortArray(int[] arr)
        {
            int i, j;
            int min, temp;

            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }

        public static double[] SortArray(double[] arr)
        {
            int i, j;
            int min;
            double temp;

            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }

        public static string[] SortArray(string[] arr)
        {
            int i, j;
            int min;
            string temp;

            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (string.Compare(arr[j], arr[min]) < 0)
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }
    }
}
