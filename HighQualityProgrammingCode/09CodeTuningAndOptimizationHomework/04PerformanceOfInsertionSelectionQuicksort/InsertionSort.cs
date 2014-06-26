namespace _04PerformanceOfInsertionSelectionQuicksort
{
    public static class InsertionSort
    {
        public static int[] SortArray(int[] arr)
        {
            int i;
            int j;
            int index;

            for (i = 1; i < arr.Length; i++)
            {
                index = arr[i];
                j = i;

                while ((j > 0) && (arr[j - 1] > index))
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }

                arr[j] = index;
            }

            return arr;
        }

        public static double[] SortArray(double[] arr)
        {
            int i;
            int j;
            double index;

            for (i = 1; i < arr.Length; i++)
            {
                index = arr[i];
                j = i;

                while ((j > 0) && (arr[j - 1] > index))
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }

                arr[j] = index;
            }

            return arr;
        }

        public static string[] SortArray(string[] arr)
        {
            int i;
            int j;
            string index;

            for (i = 1; i < arr.Length; i++)
            {
                index = arr[i];
                j = i;

                while ((j > 0) && (string.Compare(arr[j - 1], index) > 0))
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }

                arr[j] = index;
            }

            return arr;
        }
    }
}
