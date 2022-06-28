package MoreExercises;

import java.util.Scanner;

public class PrimePairs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int startFirst = Integer.parseInt(scanner.nextLine());
        int startSecond = Integer.parseInt(scanner.nextLine());
        int diffFirst = Integer.parseInt(scanner.nextLine());
        int diffSecond = Integer.parseInt(scanner.nextLine());


        for (int i = startFirst; i <= startFirst + diffFirst; i++) {
            int count1 = 0;
            for (int k = 1; k <= i; k++) {
                if (i % k == 0) {
                    count1++;
                }
                if (count1 > 2) {
                    break;
                }
            }

            for (int j = startSecond; j <= startSecond + diffSecond; j++) {
                int count2 = 0;

                for (int l = 1; l <= j; l++) {
                    if (j % l == 0) {
                        count2++;
                    }
                    if (count2 > 2) {
                        break;
                    }

                }
                if (count1 <= 2 && count2 <= 2) {
                    System.out.printf("%d%d%n", i, j);

                }
            }


        }
    }


}
