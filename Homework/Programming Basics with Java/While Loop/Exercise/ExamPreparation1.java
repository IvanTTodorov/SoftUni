package Exercise;

import java.util.Scanner;

    public class ExamPreparation1 {
        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            int num = Integer.parseInt(scanner.nextLine());
            String task = scanner.nextLine();
            int poorMarks = 0;
            double Total = 0;
            double TotalNumMarks = 0;
            boolean IsValue = true;
            String lastProblem = "";

            while (!task.equals("Enough")){

                int marks = Integer.parseInt(scanner.nextLine());
                if (marks <= 4) {
                    poorMarks++;
                }
                if (poorMarks == num) {
                    IsValue = false;
                    break;
                }

                Total += marks;
                TotalNumMarks++;
                lastProblem = task;
                task = scanner.nextLine();


                }
            if (IsValue) {
                System.out.printf("Average score: %.2f%n", Total / TotalNumMarks);
                System.out.printf("Number of problems: %.0f%n", TotalNumMarks);
                System.out.printf("Last problem: %s", lastProblem);
            }

            else {
                System.out.printf("You need a break, %d poor grades.", poorMarks);

            }

            }
        }




