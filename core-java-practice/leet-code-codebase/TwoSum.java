import java.util.*;
public class TwoSum{
    public static void main(String [] args){
        // Take the input as Array Here
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter size of array: ");
        int n = sc.nextInt();

        int[] nums = new int[n];

        System.out.println("Enter array elements:");
        for (int i = 0; i < n; i++) {
            nums[i] = sc.nextInt();
        }
          // Give the Target Sum
        System.out.print("Enter target sum: ");
        int target = sc.nextInt();
          // Intalise Map
        HashMap<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < n; i++) {
            int complement = target - nums[i];

            if (map.containsKey(complement)) {
                System.out.println("Indices: " + map.get(complement) + " and " + i);
                sc.close();
                return;
            }

            map.put(nums[i], i);
        }

        System.out.println("No two sum solution found");
    }
}