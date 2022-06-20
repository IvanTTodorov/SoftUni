package MoreExercise;

import java.util.Scanner;

public class NumbersDividedByThreeWithoutReminder {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i <= 99; i += 3) {
            if (i != 0) {
                System.out.println(i);
            }
        }
    }
}

