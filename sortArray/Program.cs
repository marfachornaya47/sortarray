using System;
class sortingArray
{
    //функция для обьединения двух массивов в один
    static int[] funcUnionArray(int[] farr, int[] sarr)
    {
        int[] res = new int[farr.Length + sarr.Length];

        for (int i = 0; i < farr.Length; i++)
        {
            res[i] = farr[i];
        }

        for (int i = farr.Length, y = 0; i < res.Length; i++, y++)
        {
            res[i] = sarr[y];
        }
        return res;
    }

    //функция сортировки массива по убыванию
    static int[] funcSortArray(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }

    static void Main()
    {
        //создаем два массива
        int a = 4, b = 8;
        int[] firArr = { 1, 2, 3, 4 };
        int[] secArr = { 40, 41, 42, 43, 44, 45, 46, 47 };

        //выводим первый массив в консоль
        Console.Write("Первый массив: ");
        for (int i = 0; i < a; i++)
        {
            Console.Write(firArr[i] + " ");
        }

        Console.WriteLine("\n");

        //выводим второй массив в консоль
        Console.Write("Второй массив: ");
        for (int i = 0; i < b; i++)
        {
            Console.Write(secArr[i] + " ");
        }

        //создаем новый массив состоящий из двух ранее созданных
        int[] res1 = funcUnionArray(firArr, secArr);

        Console.WriteLine("\n");

        Console.Write("Обьединенный массив до сортировки: ");

        //выводим обьединенный массив
        for (int i = 0; i < res1.Length; i++)
        {
            Console.Write(res1[i] + " ");
        }

        //создаем массив - отсортированный обьединенный ранее массив
        int[] res2 = funcSortArray(res1);

        Console.WriteLine("\n");

        Console.Write("Обьединенный массив после сортировки по убыванию: ");

        //выводим отсортированный по убыванию массив
        for (int i = 0; i < res2.Length; i++)
        {
            Console.Write(res2[i] + " ");
        }

        Console.ReadKey();
    }
}
