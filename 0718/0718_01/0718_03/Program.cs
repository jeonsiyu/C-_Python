using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0718_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제 풀이
            //문제1. 삼각형 모양 피라미드를 만드시오
            int floor = 5;
            //Consile.Write, Console.WriteLine 
            for (int i = 0; i< floor; i++) 
            {
                for(int j=floor-i-1; j>0; j--)
                    Console.Write("");
                for(int j= 0; j < 2*i+1;j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // 문제2. 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰수를 출력하는 프로그램을 작성하시오.
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("정수 입력");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                //if (max < numbers[i])
                //    max = numbers[i];
                max = numbers[i] > max ? numbers[i] : max;
                //if (min > numbers[i])
                //    min = numbers[i];
                min = numbers[i] < min ? numbers[i] : min;
            }
            Console.WriteLine("최댓값 : " + max + ", 최솟값 : " + min);


            // 문제4. 반복문을 사용해서 1부터 100까지 합 구하기.



            // 문제5. 한글 전부 출력하기
        }

    }

    }
}
