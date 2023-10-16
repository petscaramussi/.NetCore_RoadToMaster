﻿namespace GenericBubbleSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 2, 1, 4, 3 };

            //string[] arr = new string[] { "bob", "Henry", "Andy", "Greg" };

            Employee[] arr = new Employee[]
            {
                new Employee { Id = 4, Name = "John" },
                new Employee { Id = 2, Name = "Bob" },
                new Employee { Id = 3, Name = "Greg" },
                new Employee { Id = 1, Name = "Tom" }
            };

            SortArray<Employee> sortArray = new SortArray<Employee>();

            sortArray.BubbleSort(arr);

            foreach (var item in arr)
                Console.WriteLine(item);

            Console.ReadKey();


        }
    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Id.CompareTo(other.Id);
        }

        //public int CompareTo(object? obj)
        //{
        //    return this.Id.CompareTo(((Employee)obj).Id);
        //}

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }

    public class SortArray<T> where T:IComparable<T>
    {
        public void BubbleSort(T[] arr) 
        {
            int n = arr.Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1]) > 0) 
                    {
                        Swap(arr, j);
                    }
                }
            }  
        }

        private void Swap(T[] arr, int j)
        {
            T temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}