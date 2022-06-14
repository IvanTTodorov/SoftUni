package Exercise;

import java.util.Scanner;

public class Oscars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String nameActor = scanner.nextLine();
        double pointsFromAcademy = Double.parseDouble(scanner.nextLine());
        int n = Integer.parseInt(scanner.nextLine());
        double totalPoints = pointsFromAcademy;

        for (int i = 0; i < n; i++) {

            String nameJury = scanner.nextLine();
            double pointsJury = Double.parseDouble(scanner.nextLine());
            double pointsFromJury = nameJury.length() * pointsJury / 2;

            if (totalPoints < 1250.5) {
                totalPoints = totalPoints + pointsFromJury;
            } else {
                totalPoints = totalPoints; }

            }
            if (totalPoints >= 1250.5) {
                System.out.printf("Congratulations, %s got a nominee for leading role with %.1f!", nameActor, totalPoints);
            } else {
                System.out.printf("Sorry, %s you need %.1f more!", nameActor, Math.abs(1250.5 - totalPoints));
            }

        }

}
