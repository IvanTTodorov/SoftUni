package Lecture;

import java.util.Scanner;

public class GenderOrAge {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double Age = Double.parseDouble(scanner.nextLine());
        String Gender = scanner.nextLine();

        if (Gender.equals("m")) {
            if (Age >= 16) {
                System.out.println("Mr.");
            } else {
                System.out.println("Master");
            }
        } else if (Gender.equals("f")) {
            if (Age >= 16) {
                System.out.println("Ms.");
            } else {
                System.out.println("Miss");
            }
        } else {
            System.out.println("Error");
        }

        }
    }

