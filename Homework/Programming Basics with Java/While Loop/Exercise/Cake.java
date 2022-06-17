package Exercise;

import java.util.Scanner;

public class Cake {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int width = Integer.parseInt(scanner.nextLine());
        int length = Integer.parseInt(scanner.nextLine());
        String input = scanner.nextLine();
        int cake = width * length;


        while (!input.equals("STOP")) {
            int pieceOfCakes = Integer.parseInt(input);
            cake = cake - pieceOfCakes;

            if (cake < 0) {
                break;
            }

            input = scanner.nextLine();
        }
        if (cake < 0) {
            System.out.printf("No more cake left! You need %d pieces more.", Math.abs(cake));
        } else {
            System.out.printf("%d pieces are left.", Math.abs(cake));
        }

    }
}