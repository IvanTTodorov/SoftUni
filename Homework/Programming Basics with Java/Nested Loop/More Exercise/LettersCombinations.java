package MoreExercises;

import java.util.Scanner;

public class LettersCombinations {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char startLetter = scanner.nextLine().charAt(0);
        char EndLetter = scanner.nextLine().charAt(0);
        char ignoreLetter = scanner.nextLine().charAt(0);

        char[] combination =  new char[4];
        combination[3]= ' ';
        int combinationsFound = 0;

        for (char i = startLetter; i <= EndLetter; i++) {
            if (i != ignoreLetter) {
                combination[0] = i;
                for (char j = startLetter; j <= EndLetter; j++) {
                    if (j != ignoreLetter) {
                        combination[1] = j;
                        for (char k = startLetter; k <= EndLetter; k++) {
                            if (k != ignoreLetter) {
                                combination[2] = k;
                                System.out.print(combination);
                                combinationsFound++;

                            }
                        }
                    }
                }
            }
        }
        System.out.println(combinationsFound);

    }
}
