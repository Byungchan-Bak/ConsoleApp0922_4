using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp0922_3
{
    public class Prime
    {
        public void PrimeFormula(int max)
        {
            int min = 2;
            int[] num = new int[max];
            for (int i = 0; i < max; i++)
            {
                num[i] = min++; //최소 값 2부터 +1, 소수가 아닌 경우 데이터 재입력
                
                for (int j = 0; j < i; j++) 
                {
                    if (num[i] % num[j] == 0)   //소수가 아닌 경우
                    {
                        i--;    //해당 배열의 데이터 재입력을 위하여 i감소
                        break;  //for문 종료
                    }
                }
            }

            for(int count = 0; count < max; count++)    //소수의 개수
            {
                if (num[count] <= max)  //입력한 값 범위의 소수 출력
                {
                    Console.WriteLine($"{count+1}번째 소수 -->> {num[count]}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********소수 구하기**********(나가기 : -1)");
            while (true)
            {
                Console.Write("최대 정수를 입력하시오.(최소 2) : ");
                int.TryParse(Console.ReadLine(), out int max_value);
                if (max_value >= 2)
                {
                    Prime prime = new Prime();
                    prime.PrimeFormula(max_value);
                }
                else if(max_value == -1)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("다시 입력하십시오.");
                }
            }
        }
    }
}
