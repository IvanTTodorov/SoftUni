import java.util.Scanner;

public class CinemaTicket {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String Day = scanner.nextLine();


        if (Day.equals("Monday") ||
                Day.equals("Tuesday") ||
                Day.equals("Friday")) {
            System.out.println(12);

        } else if (Day.equals("Wednesday") ||
                Day.equals("Thursday")) {
            System.out.println(14);

        } else if (Day.equals("Saturday") ||
                Day.equals("Sunday")) {
            System.out.println(16);
        }


        }
    }
