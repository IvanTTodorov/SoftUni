package MoreExercise;

import java.util.Scanner;

public class StreamOfLetters {
    public static void main(String[] args) {

            Scanner scanner = new Scanner(System.in);
            String command = scanner.nextLine();
            boolean findC = false;
            boolean findO = false;
            boolean findN = false;
            StringBuilder word = new StringBuilder();

            while (!"End".equals(command)) {
                char a = command.charAt(0);
                if (((int) a >= 97 && (int) a <= 122) || ((int) a >= 65 && (int) a <= 90)) {
                    switch (String.valueOf(a)) {
                        case "c":
                            if(!findC){
                                findC = true;
                                a = ' ';
                            }
                            break;
                        case "o":
                            if(!findO){
                                findO = true;
                                a = ' ';
                            }
                            break;
                        case "n":
                            if(!findN){
                                findN = true;
                                a = ' ';
                            }

                            break;
                    }
                    word.append(a);
                    if(findC && findO && findN){
                        findC = false;
                        findN = false;
                        findO = false;
                        String w = word.toString();
                        w = w.replaceAll("\\s", "");
                        System.out.printf("%s ",w);
                        word.setLength(0);
                    }

                }


                command = scanner.nextLine();
            }
        }
    }