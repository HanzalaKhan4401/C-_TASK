﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//3D ARRAY
//int[,,] arr3D = new int[3, 2, 3]
//{
//    {
//        { 1,2,3},
//        { 4,5,6}
//    },
//    {
//        { 7,8,9},
//        { 0,1,2}
//    },
//    {
//        { 3,4,5},
//        { 6,7,8}
//    }
//};

//int row3d = arr3D.GetLength(0);
//int each_arr_row = arr3D.GetLength(1);
//int col = arr3D.GetLength(2);
//foreach (var item in arr3D)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(row3d + "and" + "Last_index" + each_arr_row + "length" + col.Length);

// Jagge Array
//Console.WriteLine("Jagge Array");

//int[][] jagged_array = new int[3][];

//jagged_array[0] = new int[] { 1, 2, 3 };
//jagged_array[1] = new int[] { 4, 5, 6 };
//jagged_array[2] = new int[] { 7, 8, 9 };

//Console.WriteLine(jagged_array[0][2]);

//foreach (var item in jagged_array)
//{
//    Console.WriteLine(item);
//}

//All Sum Of Integer

//int[] num = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

//int sum = 0;


//for (int i = 0; i < num.Length; i++)
//{
//    sum += num[i];
//}
//    Console.WriteLine(sum); 



//maximum and minimum values in the array.

//int[] num = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

//int max = num.Max();
//Console.WriteLine(max);

//int min = num.Min();
//Console.WriteLine(min);

//Count the number of even and odd integers in the array.

//int[] num = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        int add = num.Count();
//        Console.WriteLine(add);
//    }

//}

//Calculate the average of all the integers in the array.

//int[] num = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };
//var avg = num.Average();
//Console.WriteLine(avg);    

int[] num = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

int specificInteger = 97;
bool present = num.Contains(specificInteger);
Console.WriteLine(specificInteger + "is present" + present);