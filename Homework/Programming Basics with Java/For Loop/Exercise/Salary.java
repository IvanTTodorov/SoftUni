package Exercise;

import java.util.Scanner;

public class Salary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner (System.in);
        int n = Integer.parseInt (scanner.nextLine());
        int salary = Integer.parseInt (scanner.nextLine());


        for (int i = 0; i < n; i++ ) {
            String name = scanner.nextLine();
            if (name.equals("Facebook")) {
                salary -= 150;
                }
            if  (name.equals("Instagram")) {
                salary -= 100;
            }
            if (name.equals("Reddit")) {
                salary -= 50;
            } else {
                salary -= 0;
            }
            }

        if (salary <= 0) {
            System.out.println("You have lost your salary.");
        } else {
            System.out.printf("%d", salary);

        }
    }
}
