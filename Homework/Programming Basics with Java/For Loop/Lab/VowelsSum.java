package Lecture;

import java.util.Scanner;

public class VowelsSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner (System.in);
        String text = scanner.nextLine();
        int result = 0;

        for (int i = 0; i <= text.length() - 1; i++) {
            char symbol = text.charAt(i);
            switch (symbol) {
                case 'a':
                    result += 1;
                    break;

                case 'e':
                    result += 2;
                    break;

                case 'i':
                    result += 3;
                    break;

                case 'o':
                    result += 4;
                    break;

                case 'u':
                    result += 5;
                    break;
            }
        }
            System.out.println(result);

    }
}
