using System;
using System.Collections.Generic;

class Problem1032
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<string> fileNameList = new List<string>();
        for (int i = 0; i < count; ++i)
        {
            fileNameList.Add(Console.ReadLine());
        }

        char[] result = fileNameList[0].ToCharArray();
        //리스트에 저장
        for (int i = 1; i < fileNameList.Count; ++i)
        {
            for (int j = 0; j < fileNameList[0].Length; j++)
            {
                if (fileNameList[0][j] != fileNameList[i][j])
                {
                    result[j] = '?';
                }
            }
        }
        Console.WriteLine(string.Join("", result));
    }
}
/*
 * https://www.acmicpc.net/problem/1032
 * 첫 번째 파일 이름을 char array 형태로 저장한다.
 * 첫 번째 파일 이름과 나머지 파일 이름을 비교한다.
 * 같은 인덱스에 있는 문자가 다르면 해당 인덱스 값을 ?로 바꾼다
 */
