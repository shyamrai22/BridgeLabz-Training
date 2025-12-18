package leetcode;
import java.util.*;

public class PalindromicString {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String s = sc.next();
		int start = 0, end = s.length()-1;
		boolean flag = true;
		while(start <= end) {
			if(s.charAt(start) != s.charAt(end)) {
				flag = false;
			}
			start++;
			end--;
		}
		System.out.print(flag);
	}

}
