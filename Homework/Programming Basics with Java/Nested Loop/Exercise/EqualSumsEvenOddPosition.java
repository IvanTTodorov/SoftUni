package Exercise;

import java.util.Scanner;

public class EqualSumsEvenOddPosition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n1 = Integer.parseInt(scanner.nextLine());
        int n2 = Integer.parseInt(scanner.nextLine());


        for (int i = n1; i <= n2; i++) {
            int currentNum = i;
            int totalSumEven = 0;
            int totalSumOdd = 0;
            for (int j = 0; j <= 6; j++) {
                int digit = currentNum % 10;
                if (j % 2 == 0) {
                    totalSumEven += digit;
                } else {
                    totalSumOdd += digit;
                }
                currentNum = currentNum / 10;
            }
            if (totalSumEven == totalSumOdd) {
                System.out.print(i + " ");


            }

        }
    }

}