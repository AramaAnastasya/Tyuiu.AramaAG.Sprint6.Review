using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AramaAG.Sprint6.TaskReview.V17.Lib
{
    public class DataService
    {

        //Дан целочисленный двумерный массив N(N>1) на M(M>1) элементов, заполненный случайными числами в заданном диапазоне(от n1 до n2) с чередованием через два значения произведением двух предыдущих значений в столбцах.
        public int[,] GeneratingMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    if ((i + 1) %  3 == 0)
                    {
                        array[i, j] = Convert.ToInt32(array[i-1, j] * array[i-2, j]);
                    }
                    else
                    {
                        int a = rnd.Next(n1, n2 + 1);
                        array[i, j] = a;
                    }                    
                }
                
            }
            return array;
        }

        //Найти произведение значений из его элементов с чётными номерами от K до L(нумерация начинается с нуля) включительно в заданной строке R.
        public int resultGetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0);
            int columns = array.GetUpperBound(1) + 1;
            int y = columns;
            int mult = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == c && (j >= k && j <= l) && (j % 2 == 0 ))
                    {
                        mult *= array[i, j];
                    }
                }
            }
            return mult;
        }
    }
}
