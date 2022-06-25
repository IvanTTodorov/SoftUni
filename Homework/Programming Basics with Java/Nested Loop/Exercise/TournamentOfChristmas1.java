package Exercise;

import java.util.Scanner;

public class TournamentOfChristmas1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int tournamentDays = Integer.parseInt(scanner.nextLine());

        double totalProfit = 0;
        int countTotalWin = 0;
        int countTotalLost = 0;

        for (int i = 0; i < tournamentDays; i++) {
            double dailyProfit = 0;
            int countDailyWinGames = 0;
            int countDailyLostGames = 0;

            String input = scanner.nextLine();
            while (!input.equals("Finish")) {
                String typeGame = input;
                String gameResult = scanner.nextLine();

                if (gameResult.equals("win")) {
                    dailyProfit = dailyProfit + 20;
                    countDailyWinGames++;
                } else {
                    countDailyLostGames++;
                }

                input = scanner.nextLine();
            }
            if (countDailyWinGames > countDailyLostGames) {
                dailyProfit = dailyProfit  * 1.10;
            }

            countTotalWin = countTotalWin + countDailyWinGames;
            countTotalLost = countTotalLost + countDailyLostGames;

            totalProfit = totalProfit + dailyProfit;
        }

        if (countTotalWin > countTotalLost) {
            System.out.print("You won the tournament! ");
            System.out.printf("Total raised money: %.2f", totalProfit * 1.20);
        } else {
            System.out.print("You lost the tournament! ");
            System.out.printf("Total raised money: %.2f", totalProfit);

        }
    }
}
