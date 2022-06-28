package MoreExercises;

import java.util.Scanner;

public class Profit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int oneLev = Integer.parseInt (scanner.nextLine());
        int twoLeva = Integer.parseInt (scanner.nextLine());
        int fiveLeva = Integer.parseInt (scanner.nextLine());
        int total = Integer.parseInt (scanner.nextLine());


        for (int i = 0; i <= oneLev; i++ ) {
            int total1lev = i;
            for (int j = 0; j <= twoLeva; j++ ) {
                int total2lev = 2 * j;
                for (int k = 0; k <= fiveLeva; k++ ) {
                    int total5leva = 5 * k;
                    if (total1lev + total2lev + total5leva == total) {
                        System.out.printf(" %d * 1 lv. + %d * 2 lv. + %d * 5 lv. = %d lv.%n", i, j, k, total);}

                        }
                    }
                }
    }
}
