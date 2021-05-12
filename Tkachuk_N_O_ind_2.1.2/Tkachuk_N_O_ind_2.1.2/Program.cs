using System;


namespace ind_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Кiлькiсть елементiв масиву: ");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Введiть чиcла масиву: ");
            input_array(array, n);

            

            Console.WriteLine("Початковий масив: ");

         
            output_array(array, n);


            Console.WriteLine("\nВiдсортований масив: ");

            bubble_sort(array, n);
            output_array(array, n);

            Console.Read();
        }


        static void input_array(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void output_array(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + "\t");            
            }
        }

        static void bubble_sort(int[] array, int n)
        {
            int a;
            bool temp = true;

            while (temp)
            {
                temp = false;

                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] < array[i])
                    {
                        a = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = a;
                        
                        temp = true;
                    }
                }

            }

        }

    }

}