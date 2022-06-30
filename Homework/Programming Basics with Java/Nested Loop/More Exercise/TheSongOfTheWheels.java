package MoreExercises;

import java.util.Scanner;

public class TheSongOfTheWheels {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int M = Integer.parseInt(scanner.nextLine());
        int count = 0;

        int g = 0;
        int h = 0;
        int k = 0;
        int l = 0;


        for (int a = 1; a <= 9; a++) {
            for (int b = 1; b <= 9; b++) {
                for (int c = 1; c <= 9; c++) {
                    for (int d = 1; d <= 9; d++) {
                        if (a < b && c > d) {
                            if ((a * b) + (c * d) == M) {
                                System.out.printf("%d%d%d%d ", a, b, c, d);
                                count++;

                                if (count == 4) {
                                    g = a;
                                    h = b;
                                    k = c;
                                    l = d;

                                }


                            }


                        }
                    }
                }
            }
        }
        if (count >= 4 ) {
            System.out.println("");
            System.out.printf("Password: %d%d%d%d ", g, h, k, l);
        }

        else  {
            System.out.println("");
            System.out.println("No!");
        }
    }
}