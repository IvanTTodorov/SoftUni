package Lecture;

import java.util.Scanner;

public class Password {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String username = scanner.nextLine();
        String password = scanner.nextLine();
        String password1 = scanner.nextLine();

        while (!password1.equals(password)) {
            password1 = scanner.nextLine();
        }
        System.out.println("Welcome " + username + "!");


        }
    }

