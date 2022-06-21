package Lecture;

import java.util.Scanner;

public class Building {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int floor = Integer.parseInt(scanner.nextLine());
        int rooms = Integer.parseInt(scanner.nextLine());
        int countFloor = 0;
        int countRoom = 0;

        for (countFloor = floor; countFloor >= 1; countFloor--) {
            for (countRoom = 0; countRoom < rooms; countRoom++) {

                if (floor == countFloor || floor == 1) {
                    System.out.printf("L%d%d ", countFloor, countRoom);
                } else if (countFloor % 2 == 0) {
                    System.out.printf("O%d%d ", countFloor, countRoom);
                } else if (countFloor % 2 != 0) {
                    System.out.printf("A%d%d ", countFloor, countRoom);
                }
            }
            System.out.println();
        }
    }

}






