import java.util.*;
public class MajorityElement{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter size of array: ");
        int n = sc.nextInt();

        int[] nums = new int[n];

        System.out.println("Enter array elements:");
        for (int i = 0; i < n; i++) {
            nums[i] = sc.nextInt();
        }

        // Step 1: Find number
        int number = 0;
        int count = 0;

        for (int num : nums) {
            if (count == 0) {
             number = num;
            }
            count += (num == number) ? 1 : -1;
        }

        // Step 2: Verify number
        count = 0;
        for (int num : nums) {
            if (num == number) {
                count++;
            }
        }

        if (count > n / 2) {
            System.out.println("Majority Element: " + number);
        } else {
            System.out.println("No Majority Element found");
        }

    }
}