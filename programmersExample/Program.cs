using System;

public class Solution
{
    public static void Main()
    {
        // 리스트를 적절히 초기화
        List<int> testListInt = new List<int> { 5, 2, 7, 5  };
        int n = 3;
        // 리스트를 배열로 변환하여 solution 메서드 호출
        int[] result = solution(testListInt.ToArray(), n);
    }
    public static int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[] { };
        return answer;
    }
}