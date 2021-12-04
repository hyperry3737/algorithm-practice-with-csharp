/*
 * - 문제 -
 * 큰 수의 법칙
 * 배열의 크기 N, 숫자의 개수 M, 한번에 큰 숫자가 더해지는 횟수 K가 주어졌을 때
 * {2,4,5,4,6}으로 이루어진 배열이 있을 때 M이 8이고 K가 3이라면
 * 큰 수의 법칙에 따라 6 + 6 + 6 + 5 + 6 + 6 + 6 + 5 = 46이 된다.
 * 
 * 자연수를 입력 받을 때 공백으로 구분한다.
 */
using System;
class Page92
{
    static void Main()
    {
        int result = 0;
        string nmk = Console.ReadLine();
        int[] nmkArray = Array.ConvertAll(nmk.Split(' '), int.Parse);
        int n = nmkArray[0];
        int m = nmkArray[1];
        int k = nmkArray[2];

        string input = Console.ReadLine();
        int[] inputArray = Array.ConvertAll(input.Split(' '),int.Parse);
        Array.Sort(inputArray);
        int first = inputArray[n-1];
        int second = inputArray[n-2];
        result += m / (k+1) * (first*k+second); //반복되는 값을 이용
        result += m % (k+1) * first; //더 이상 반복되지 않으므로 최댓값만 사용
        Console.WriteLine(result);
    }
}
/*
 * - 문제 해결 -
 * 무작정 반복문을 사용하지 않는다.
 * 배열의 특징을 찾는다. (반복됨)
 * 배열의 특징을 이용하여 문제 해결
 */

