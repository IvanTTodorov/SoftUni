package MoreExercises;

import java.util.Scanner;

public class SumofTwoNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int start = Integer.parseInt(scanner.nextLine());
        int end = Integer.parseInt(scanner.nextLine());
        int magicNum = Integer.parseInt(scanner.nextLine());
        int countCombination = 0;
boolean isValid = false;

        for (int i = start; i <= end; i++) {
            for (int j = start; j <= end; j++) {
                countCombination += 1;
                if (i + j == magicNum) {
                    System.out.printf("Combination N:%d (%d + %d = %d)", countCombination, i, j, magicNum);
                    isValid = true;
                    break;
                }
                }
            if (isValid) {
                break;}
            }
        if (!isValid) {
            System.out.printf("%d combinations - neither equals %d", countCombination, magicNum);

        }
    }
}