package Lecture;

import java.util.Scanner;

public class Clock {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
 for (int h = 0; h <= 23; h++ ) {
     for (int m = 0; m <= 59; m++ ) {
         System.out.printf("%02d:%02d%n", h, m);
             }
         }
     }
}
