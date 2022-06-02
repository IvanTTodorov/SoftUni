import java.util.Scanner;

public class LunchBreak {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String Series = scanner.nextLine();
        int TimeE = Integer.parseInt(scanner.nextLine());
        int TimeR = Integer.parseInt(scanner.nextLine());

        double TimeL = TimeR / 8.0;
        double TimeRelax = TimeR / 4.0;
        double LeftTime = TimeR - TimeL - TimeRelax;
        double diff = Math.abs(LeftTime - TimeE);
        diff = Math.ceil(diff);
        if (LeftTime >= TimeE) {
            System.out.printf("You have enough time to watch %s and left with %.0f minutes free time.", Series, diff);

        } else {
            System.out.printf("You don't have enough time to watch %s, you need %.0f more minutes.", Series, diff);
        }
    }
}