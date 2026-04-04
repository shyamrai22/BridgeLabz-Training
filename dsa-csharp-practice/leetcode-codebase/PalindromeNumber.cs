public class Solution
{
  public bool IsPalindrome(int x)
  {
    string num = x.ToString();
    int left = 0;
    int right = num.Length - 1;
    while (left < right)
    {
      if (num[left] != num[right])
      {
        return false;
      }
      left++;
      right--;
    }
    return true;
  }
}