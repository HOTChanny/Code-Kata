public class Solution {
    public string solution(int num) {
        string answer = "";
        
        if( num%2==0)
        
            answer += "Even";
        
        else
        
            answer += "Odd";
            return answer;
        
        
    }
    // 1줄코드 return (num % 2 == 0) ? "Even" : "Odd";
}