package Exercise;

import java.util.Scanner;

public class Moving {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int width = Integer.parseInt (scanner.nextLine());
        int lenght = Integer.parseInt (scanner.nextLine());
        int h = Integer.parseInt (scanner.nextLine());
        String input = scanner.nextLine();
        int totalSpace = width * lenght * h;
        int totalBoxes = 0;

        while (!input.equals("Done")) {
            int boxes = Integer.parseInt (input);
            totalBoxes += boxes;

            if (totalBoxes >= totalSpace) {
                break;
            }
            input = scanner.nextLine();
            }
        int diff = Math.abs (totalSpace - totalBoxes);
            if (totalSpace > totalBoxes) {
                System.out.printf("%d Cubic meters left.", diff);

            } else {
                System.out.printf("No more free space! You need %d Cubic meters more.", diff);

            }

        }
    }

