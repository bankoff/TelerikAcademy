namespace _04PerformanceOfInsertionSelectionQuicksort
{
    public static class QuickSort
    {
        public static void Quicksort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                Quicksort(input, left, q - 1);
                Quicksort(input, q + 1, right);
            }
        }

        public static void Quicksort(double[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                Quicksort(input, left, q - 1);
                Quicksort(input, q + 1, right);
            }
        }

        public static void Quicksort(string[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                Quicksort(input, left, q - 1);
                Quicksort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[right];
            int temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        private static int Partition(double[] input, int left, int right)
        {
            double pivot = input[right];
            double temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        private static int Partition(string[] input, int left, int right)
        {
            string pivot = input[right];
            string temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (string.Compare(input[j], pivot) <= 0)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }
    }
}
