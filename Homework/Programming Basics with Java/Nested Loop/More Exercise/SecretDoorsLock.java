package MoreExercises;

import java.util.Scanner;

public class SecretDoorsLock {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int maxHundreds = Integer.parseInt(scanner.nextLine());
        int maxTens = Integer.parseInt(scanner.nextLine());
        int maxUnits = Integer.parseInt(scanner.nextLine());
        boolean isEven = true;


        for (int i = 1; i <= maxHundreds; i++) {
            if (i % 2 != 0) {
                isEven = false;
            } else {
                isEven = true;
                for (int j = 1; j <= maxTens; j++) {
                    if (j != 2 && j != 3 && j != 5 && j != 7) {
                        isEven = false;
                    } else {
                        isEven = true;
                        for (int k = 1; k <= maxUnits; k++) {
                            if (k % 2 != 0) {
                                isEven = false;
                            } else {
                                isEven = true;
                            }
                            if (isEven)
                                System.out.printf("%d %d %d%n", i, j, k);
                        }
                    }
                }
            }
        }
    }
}