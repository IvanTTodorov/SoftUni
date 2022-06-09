package Lecture;

import java.util.Scanner;

public class EvenPowers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i <= n; i += 2) {
            double result = Math.pow(2,i);
            System.out.printf("%.0f%n", result);
        }
    }
}