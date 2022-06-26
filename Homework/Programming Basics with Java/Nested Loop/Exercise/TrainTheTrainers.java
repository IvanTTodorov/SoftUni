package Exercise;

import java.util.Scanner;

public class TrainTheTrainers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numJury = Integer.parseInt(scanner.nextLine());
        String input = scanner.nextLine();
        double sumGrades = 0;
        double count = 0;


        while (!input.equals("Finish")) {
            String presentationName = input;

            double totalAssesment = 0;

            for (int i = 0; i < numJury; i++) {
                double assesment = Double.parseDouble(scanner.nextLine());
                totalAssesment += assesment;
                count ++;
            }

            sumGrades += totalAssesment;

            double average = totalAssesment / numJury;

            System.out.printf("%s - %.2f.%n", presentationName, average);

            input = scanner.nextLine();
        }
        System.out.printf("Student's final assessment is %.2f.", sumGrades / count);
    }
}
