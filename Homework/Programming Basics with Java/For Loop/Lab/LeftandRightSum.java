package Lecture;

import java.util.Scanner;

public class LeftandRightSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++) {
            int number = Integer.parseInt(scanner.nextLine());
            leftSum += number;
        }

        for (int i = 0; i < n; i++) {
            int number = Integer.parseInt(scanner.nextLine());
            rightSum += number;
        }

        if (rightSum == leftSum) {
            System.out.printf("Yes, sum = %d", rightSum);
        } else {
            int diff = Math.abs(leftSum - rightSum);
            System.out.printf("No, diff = %d", diff);


        }
    }
}
