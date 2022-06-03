package Exercise;

import java.util.Scanner;

public class TimePlus15Minutes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int Hours = Integer.parseInt(scanner.nextLine());
        int Minutes = Integer.parseInt(scanner.nextLine());

        int AllMinutes = (Hours * 60) + Minutes + 15;
        int NewHours = AllMinutes / 60;
        int NewMinutes = AllMinutes % 60;

        if (NewHours > 23) {
            NewHours = 0;
            System.out.printf("%d:%02d", NewHours, NewMinutes);
        } else {
            System.out.printf("%d:%02d", NewHours, NewMinutes);


        }


    }
}


