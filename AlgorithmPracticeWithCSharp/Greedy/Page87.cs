/*
 * - 문제 -
 * 카운터에는 거스름돈으로 사용할 500원, 100원, 50원, 10원짜리 동전이 무한히 존재한다고 가정한다. 
 * 손님에게 거슬러 줘야 할 돈이 N원일 때 거슬러 줘야 할 동전의 최소 개수를 구하라.
 * 단, 거슬러 줘야 할 돈 n은 항상 10의 배수이다. 
 */
using System;
class Page87
{
    static void Main()
    {
        int n = 1260; //거슬러 줘야할 돈
        int count = 0;
        int[] coinTypes = { 500, 100, 50, 10 };
        
        foreach(int coin in coinTypes)
        {
            count += n / coin;
            n %= coin;
        }
        Console.WriteLine(count);
    }
}
/*
 * - 문제 해결 -
 * 가장 큰 화폐 단위부터 돈을 거슬러 주는 것이다.
 * 1. 500원으로 거슬러 줄 수 있을 만큼 거슬러 준다.
 * 2. 100원...
 * 3. 50원...
 * 4. 10원...
 * 몫과 나머지를 구한다. (순서 중요)
 */