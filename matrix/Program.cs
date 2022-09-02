using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность квадратной матрицы, но не более 4");
        int a = int.Parse(Console.ReadLine());
        float ad = 0;
        float ad11 = 0;
        float ad12 = 0;
        float ad13 = 0;
        float ad14 = 0;
        float ad21 = 0;
        float ad22 = 0;
        float ad23 = 0;
        float ad24 = 0;
        float ad31 = 0;
        float ad32 = 0;
        float ad33 = 0;
        float ad34 = 0;
        float ad41 = 0;
        float ad42 = 0;
        float ad43 = 0;
        float ad44 = 0;
        int min1 = 0;
        int min2 = 0;
        int min3 = 0;
        float dop1 = 0;
        float dop2 = 0;
        float dop3 = 0;
        float dop4 = 0;
        float dop5 = 0;
        float dop6 = 0;
        float dop7 = 0;
        float dop8 = 0;
        float dop9 = 0;


        int[,] matrix = new int[a, a];
        int [,] matmin = new int[a, a];
        if (a == 0)
        {
            Console.WriteLine("Такой матрицы не может существовать");
        }
        if (a == 1)
        {
            return;
        }
        if (a > 1 || a < 4)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("mat[" + i + "," + j + "]: ");
                     matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        if (a == 2) 
        {
            ad = (matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]);

            Console.WriteLine("определитель равен " + ad);

            ad = 1 / ad;

            if (ad == 0)
            {
                Console.WriteLine("Определитель равен нулю, обратной матрицы не существует");
                return;
            } 
            Console.WriteLine("Обратная матрица равна");
            Console.Write(matrix[1,1] * ad);
            Console.WriteLine(" " + -matrix[0, 1] * ad);
            Console.Write(-matrix[1, 0] * ad);
            Console.Write(" " + matrix[0, 0] * ad);
        }
        if (a == 3)
        {
            min1 = matrix[0,0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2]));
            min2 = -matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[2, 0] * matrix[1, 2]));
            min3 = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[2, 0] * matrix[1, 1]));
            ad =(min1 + min2 + min3);
            Console.WriteLine("определитель равен " + ad);
            ad = 1 / ad;
            if (ad == 0)
            {
                Console.WriteLine("Определитель равен нулю, обратной матрицы не существует");
                return;
            }
            dop1 = (matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2]);
            dop2 = (matrix[1, 0] * matrix[2, 2]) - (matrix[2, 0] * matrix[1, 2]);
            dop3 = (matrix[1, 0] * matrix[2, 1]) - (matrix[2, 0] * matrix[1, 1]);
            dop4 = (matrix[0, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[0, 2]);
            dop5 = (matrix[0, 0] * matrix[2, 2]) - (matrix[0, 2] * matrix[2, 0]);
            dop6 = (matrix[0, 0] * matrix[2, 1]) - (matrix[2, 0] * matrix[0, 1]);
            dop7 = (matrix[0, 1] * matrix[1, 2]) - (matrix[1, 1] * matrix[0, 2]);
            dop8 = (matrix[0, 0] * matrix[1, 2]) - (matrix[1, 0] * matrix[0, 2]);
            dop9 = (matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]);
            Console.Write(" " + dop1 * ad);
            Console.Write(" " + dop4 * ad);
            Console.WriteLine(" " + dop7 * ad);
            Console.Write(" " + dop2 * ad) ;
            Console.Write(" " + dop5 * ad);
            Console.WriteLine(" " + dop8 * ad);
            Console.Write(" " + dop3 * ad);
            Console.Write(" " + dop6 * ad);
            Console.Write(" " + dop9 * ad);
            Console.ReadLine();
        }
        if (a == 4)
        {
            // Нашел определитель
            min1 = (matrix[2, 2] * matrix[3, 3]) - (matrix[3,2] * matrix[2,3]);
            min2 = (matrix[1, 2] * matrix[3, 3]) - (matrix[3,2] * matrix[1, 3]);
            min3 = (matrix[1, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[1, 3]);
            ad11 = (matrix[1,1]* min1 + matrix[2,1] * -min2 + matrix[3,1] * min3);


            min1 = (matrix[2, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[2, 3]);
            min2 = (matrix[0, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[0, 3]);
            ad21 = (matrix[0,1] * min1 - matrix[2,1] * min2 + matrix[3,1] * min3); 
            
            
            min1 = (matrix[1, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[1, 3]);
            min2 = (matrix[0, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[1, 3]) - (matrix[1, 2] * matrix[0, 3]);
            ad31 = ((matrix[0, 1] * min1) - (min2 * matrix[1, 1]) + (matrix[3,1] * min3));
            
            
            min1 = (matrix[1, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[1, 3]);
            min2 = (matrix[0, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[1, 3]) - (matrix[1, 2] * matrix[0, 3]);
            ad41 = (matrix[0,1] * min1 - min2 * matrix[1,1] + matrix[2,1] * min3);
            ad = (matrix[0,0] * ad11 - matrix[1,0] * ad21 + matrix[2,0] * ad31 - matrix[3,0] * ad41);
            Console.WriteLine("определитель равен " + ad);
            ad = (1 / ad);
            if (ad == 0)
            {
                Console.WriteLine("Определитель равен нулю, обратной матрицы не существует");
                return;
            }
            // ищу определитель каждой матрицы 3 * 3 что бы создать матрицы алгебраических дополнений
            min1 = (matrix[2,2] * matrix[3,3]) - (matrix[3,2] * matrix[2,3]);
            min2 = (matrix[1,2] * matrix[3,3]) - (matrix[3,2] * matrix[1,3]);
            min3 = (matrix[1, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[1, 3]);
            ad12 = (matrix[1, 0] * min1 - min2 * matrix[2, 0] + matrix[3, 0] * min3);


            min1 = (matrix[2, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[2, 3]);
            min2 = (matrix[1, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[1, 3]);
            min3 = (matrix[1, 1] * matrix[2, 3]) - (matrix[2, 1] * matrix[1, 3]);
            ad13 = (matrix[1, 0] * min1 - min2 * matrix[2, 0] + matrix[3, 0] * min3);


            min1 = (matrix[2, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[2, 2]);
            min2 = (matrix[1, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[1, 2]);
            min3 = (matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 1]);
            ad14 = (matrix[1, 0] * min1 - min2 * matrix[2, 0] + matrix[3, 0] * min3);


            min1 = (matrix[2, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[2, 3]);
            min2 = (matrix[0, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[0, 3]);
            ad22 = (matrix[0, 0] * min1 - matrix[2, 0] * min2 + matrix[3, 0] * min3);


            min1 = (matrix[2, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[2, 3]);
            min2 = (matrix[0, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[0, 3]);
            min3 = (matrix[0, 1] * matrix[2, 3]) - (matrix[2, 1] * matrix[0, 3]);
            ad23 = (matrix[0, 0] * min1 - matrix[2, 0] * min2 + matrix[3, 0] * min3);


            min1 = (matrix[2, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[2, 2]);
            min2 = (matrix[0, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[0, 2]);
            min3 = (matrix[0, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[0, 3]);
            ad24 = (matrix[0, 0] * min1 - matrix[2, 0] * min2 + matrix[3, 0] * min3);


            min1 = (matrix[1, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[1, 3]);
            min2 = (matrix[0, 2] * matrix[3, 3]) - (matrix[3, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[1, 3]) - (matrix[1, 2] * matrix[0, 3]);
            ad32 = ((matrix[0, 0] * min1) - (min2 * matrix[1, 0]) + (matrix[3, 0] * min3));


            min1 = (matrix[1, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[1, 3]);
            min2 = (matrix[0, 1] * matrix[3, 3]) - (matrix[3, 1] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[1, 3]) - (matrix[1, 2] * matrix[0, 3]);
            ad33 = ((matrix[0, 0] * min1) - (min2 * matrix[1, 0]) + (matrix[3, 0] * min3));


            min1 = (matrix[1, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[1, 2]);
            min2 = (matrix[0, 1] * matrix[3, 2]) - (matrix[3, 1] * matrix[0, 2]);
            min3 = (matrix[0, 1] * matrix[1, 2]) - (matrix[1, 1] * matrix[0, 2]);
            ad34 = ((matrix[0, 0] * min1) - (min2 * matrix[1, 0]) + (matrix[3, 0] * min3));


            min1 = (matrix[1, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[1, 3]);
            min2 = (matrix[0, 2] * matrix[2, 3]) - (matrix[2, 2] * matrix[0, 3]);
            min3 = (matrix[0, 2] * matrix[1, 3]) - (matrix[1, 2] * matrix[0, 3]);
            ad42 = (matrix[0, 0] * min1 - min2 * matrix[1, 0] + matrix[2, 0] * min3);


            min1 = (matrix[1, 1] * matrix[2, 3]) - (matrix[2, 1] * matrix[1, 3]);
            min2 = (matrix[0, 1] * matrix[2, 3]) - (matrix[2, 1] * matrix[0, 3]);
            min3 = (matrix[0, 1] * matrix[1, 3]) - (matrix[1, 1] * matrix[0, 3]);
            ad43 = (matrix[0, 0] * min1 - min2 * matrix[1, 0] + matrix[2, 0] * min3);

            
            min1 = (matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2]);
            min2 = (matrix[0, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[0, 2]);
            min3 = (matrix[0, 1] * matrix[1, 2]) - (matrix[1, 1] * matrix[0, 2]);
            ad44 = (matrix[0, 0] * min1 - min2 * matrix[1, 0] + matrix[2, 0] * min3);

            //вывожу обратную матрицы

            Console.Write(" " + ad11 * ad);
            Console.Write(" " + ad21 * ad);
            Console.Write(" " + ad31 * ad);
            Console.WriteLine(" " + ad41 * ad);
            Console.Write(" " + ad12 * ad);
            Console.Write(" " + ad22 * ad);
            Console.Write(" " + ad32 * ad);
            Console.WriteLine(" " + ad42 * ad);
            Console.Write(" " + ad13 * ad);
            Console.Write(" " + ad23 * ad);
            Console.Write(" " + ad33 * ad);
            Console.WriteLine(" " + ad43 * ad);
            Console.Write(" " + ad14 * ad);
            Console.Write(" " + ad24 * ad);
            Console.Write(" " + ad34 * ad);
            Console.WriteLine(" " + ad44 * ad);

            Console.ReadLine();
        }
    }
}