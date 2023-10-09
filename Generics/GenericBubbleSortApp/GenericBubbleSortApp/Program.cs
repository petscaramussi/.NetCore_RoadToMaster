namespace GenericBubbleSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] arr = new object[] { 1, 2, 3 };

            SortArray sortArray = new SortArray();

            sortArray.BubbleSort(arr);




        }
    }

    public class SortArray
    {
        public void BubbleSort(object[] arr) 
        {
            int n = arr.Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - 1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j+1]) > 0) 
                    {
                        Swap(arr, j);
                    }
                }
            }  
        }

        private void Swap(object[] arr, int j)
        {
            object tempo = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = tempo;
        }
    }
}