package Exercise;

import java.util.Scanner;

public class Walking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int totalSteps = 0;
        int diff = 0;
        String input = scanner.nextLine();

        while (!input.equals("Going home")) {
            int steps = Integer.parseInt(input);
            totalSteps += steps;
            if (totalSteps >= 10000) {
                break;
            }

            input = scanner.nextLine();
        }
        if (input.equals("Going home")) {
            int goingHomeSteps = Integer.parseInt(scanner.nextLine());
            totalSteps = totalSteps + goingHomeSteps;
        }
diff = Math.abs(totalSteps - 10000);

        if (totalSteps >= 10000) {
            System.out.println("Goal reached! Good job!");
            System.out.printf("%d steps over the goal!", diff);
        } else {
            System.out.printf("%d more steps to reach goal.", diff);
        }
    }
}

