using System;

public class Program
{
    public static void Main(string[] args)
    {

        double currentMoney = double.Parse(Console.ReadLine());
        string gameName = Console.ReadLine();
        double totalPrice = 0;



        
       while (gameName != "Game Time")
        {
            double gamePrice = 0;




            if (gameName == "OutFall 4")
            {
                gamePrice = 39.99;
                totalPrice += gamePrice;
                if (totalPrice <= currentMoney)
                {
              
                    Console.WriteLine($"Bought {gameName}");
                } else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                    
                }
                

            }
            else if (gameName == "CS: OG")
            {
                gamePrice = 15.99;
                totalPrice += gamePrice;
                if (totalPrice <= currentMoney)
                {

                    
                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                   
                }
            }
            else if (gameName == "Zplinter Zell")
            {
                gamePrice = 19.99;
                totalPrice += gamePrice;
                if (totalPrice <= currentMoney)
                {

                    
                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                    
                }
            }
            else if (gameName == "Honored 2")
            {
                gamePrice = 59.99;
                totalPrice += gamePrice;

                if (totalPrice <= currentMoney)
                {

                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                    
                }
            }
            else if (gameName == "RoverWatch")
            {
                gamePrice = 29.99;
                totalPrice += gamePrice;
                if (totalPrice <= currentMoney)
                {

                  
                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                    
                }
            }
            else if (gameName == "RoverWatch Origins Edition")
            {
                gamePrice = 39.99;
                totalPrice += gamePrice;
                if (totalPrice <= currentMoney)
                {

                    
                    Console.WriteLine($"Bought {gameName}");
                }
                else
                {
                    totalPrice -= gamePrice;
                    Console.WriteLine("Too Expensive");
                   
                }
            }
            else
            {
                Console.WriteLine("Not Found");
                
            }


            if (currentMoney == 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }
            
            gameName = Console.ReadLine();


        } double remaining = currentMoney - totalPrice;
        Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${remaining:f2}");
        
    }
}
