package MoreExercises;

import java.util.Scanner;

public class SafePasswordsGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = Integer.parseInt(scanner.nextLine());
        int b = Integer.parseInt(scanner.nextLine());
        int maxNum = Integer.parseInt(scanner.nextLine());

        char A = (char)35;
        char B = (char)64;
        int count = 0;

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= b; j++)
            {
                count++;

                System.out.printf("%c%c%d%d%c%c|", A, B, i, j, B, A);

                A++;
                B++;

                if (A > 55)
                {
                    A = (char)35;
                }
                if (B > 96)
                {
                    B = (char)64;
                }
                if (count >= maxNum)
                {
                    return;
                }
            }
        }
    }
}



