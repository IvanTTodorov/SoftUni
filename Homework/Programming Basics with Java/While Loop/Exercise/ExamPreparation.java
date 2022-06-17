package Exercise;

import java.util.Scanner;

public class ExamPreparation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int num = Integer.parseInt(scanner.nextLine());

        int poorMarks = 0;
        double Total = 0;
        double TotalNumMarks = 0;
        boolean IsValue = true;
        String lastProblem = "";

        while (poorMarks < num){
            String task = scanner.nextLine();
            if ("Enough".equals(task)) {
                IsValue = false;
                break;
            }
            int marks = Integer.parseInt(scanner.nextLine());
            if (marks <= 4) {
                poorMarks++;
            }
            Total += marks;
            TotalNumMarks++;
            lastProblem = task;
        }
        if (IsValue) {
            System.out.printf("You need a break, %d poor grades.", poorMarks);
        }

        else {
                System.out.printf("Average score: %.2f%n", Total / TotalNumMarks);
                System.out.printf("Number of problems: %.0f%n", TotalNumMarks);
                System.out.printf("Last problem: %s", lastProblem);
        }
        }
    }

