using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace arrayDemo

{

    class _2DArray

    {

        int[,] arr = new int[4, 5];

        int r, c;



        public void accessarray()

        {

            Console.WriteLine("enter no of rows of array");

            r = int.Parse(Console.ReadLine());

            Console.WriteLine("enter no of columns of array");

            c = int.Parse(Console.ReadLine());

            Console.WriteLine("enter no of array Element");



            for (int i = 0; i < r; i++)

            {

                for (int j = 0; j < c; j++)

                {

                    arr[i, j] = int.Parse(Console.ReadLine());

                }

            }

        }

        //printing the array

        public void printarray()

        {

            for (int i = 0; i < r; i++)

            {

                for (int j = 0; j < c; j++)

                {

                    Console.Write(arr[i, j] + " ");

                }

                Console.WriteLine();

            }

        }

        public static void Main()

        {

            _2DArray obj = new _2DArray();

            obj.accessarray();

            obj.printarray();

            Console.ReadKey();

        }

    }

}
