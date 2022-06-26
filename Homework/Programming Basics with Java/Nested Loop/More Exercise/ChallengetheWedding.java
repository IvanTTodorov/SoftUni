package MoreExercises;

import java.util.Scanner;

public class ChallengetheWedding {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int men = Integer.parseInt(scanner.nextLine());
        int women = Integer.parseInt(scanner.nextLine());
        int tables = Integer.parseInt(scanner.nextLine());
        int tableCounter = 0;


        for (int j = 1; j <= men; j++) {
            for (int k = 1; k <= women; k++) {

                System.out.printf("(%d <-> %d) ", j, k);
                tableCounter++;
                if (tableCounter == tables) {
                    return;

                }
            }
        }
    }

}
