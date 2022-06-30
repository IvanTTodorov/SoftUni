package MoreExercises;

import java.util.Scanner;

public class UniquePINCodes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int first = Integer.parseInt(scanner.nextLine());
        int second = Integer.parseInt(scanner.nextLine());
        int third = Integer.parseInt(scanner.nextLine());


        for (int i = 2; i <= first; i++) {
            for (int j = 2; j <= second; j++) {
                    for (int k = 2; k <= third; k++) {
                        if ((i % 2 == 0) && (k % 2 == 0) && (j != 4) && (j !=6) && (j != 8) && (j != 9)) {
                            System.out.printf("%d %d %d %n", i, j , k);
                        }

                    }
                }
            }
        }
    }
