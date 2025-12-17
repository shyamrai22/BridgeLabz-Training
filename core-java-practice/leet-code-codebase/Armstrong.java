import java.util.*;
public class Armstrong{
    public static void main(String[] args) {
        // Take Input
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter a number: ");
        int num = sc.nextInt();
         // Logic to find if  the number is Armstrong or Not
        int originalNum = num;
        int sum = 0;

        while (num != 0) {
            int digit = num % 10;
            sum = sum + (digit * digit * digit);
            num = num / 10;
        }

        if (originalNum == sum) {
            System.out.println(originalNum + " is an Armstrong Number");
        } else {
            System.out.println(originalNum + " is NOT an Armstrong Number");
        }

    }
}