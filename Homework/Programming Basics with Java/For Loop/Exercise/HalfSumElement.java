package Exercise;

import java.util.Scanner;

public class HalfSumElement {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        int sum = 0;
        int maxNum = Integer.MIN_VALUE;
        for (int i = 0; i < n; i++) {
            int currentNum = Integer.parseInt(scanner.nextLine());

            sum += currentNum;

            if (currentNum > maxNum) {
                maxNum = currentNum;
            }
        }
        int sumWithoutMax = sum - maxNum;
        if (maxNum == sumWithoutMax) {
            System.out.println("Yes");
            System.out.printf("Sum = %d", sumWithoutMax);
        } else {
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(maxNum - sumWithoutMax));

        }

    }
}