Console.WriteLine("Welcom to the ATM");
Console.WriteLine("inter your PIN (Defult is 1234)");
string pin = Console.ReadLine();
if (pin == "1234")
{
    Console.WriteLine("Your PIN Is correct");
    bool isCorrect = true;
    Console.WriteLine(" please Add amount to your account");

    double balance = double.Parse(Console.ReadLine());

    while (isCorrect)
    {
        Console.WriteLine("######################### ATM APP ##########################");
        Console.WriteLine("1 <- to check your balance #################################");
        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("2 <- to withdraw  ##########################################");

        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("3 <- to Depsoit  ###########################################");

        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("4 <- to Exit  ##############################################");
        Console.WriteLine("############################################################");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1": 
                Console.WriteLine($"your currint balance is : {balance} R.Y");
                break;
            case "2": 
            
                Console.WriteLine($"Avilable balance is : {balance} R.Y ");
                Console.WriteLine("Inter the amount you need..  ");
               
                double WithdrawBalance = 0;
                WithdrawBalance =  double.Parse( Console.ReadLine());
                
                
               
                if (WithdrawBalance < balance)
                {
                    balance -= WithdrawBalance;
                    Console.WriteLine($" Succes, your balance is : {balance} R.Y ");

                }
                else {

                    Console.WriteLine($" Sorry your balance not much  : {balance} R.Y ");

                }


                break;
            case "3":
                Console.WriteLine($"Avilable balance is : {balance} R.Y ");
                Console.WriteLine("inter the amount to your account  ");
          
                double AddBalance = 0;
                AddBalance = double.Parse(Console.ReadLine());

                
                balance += AddBalance;
                Console.WriteLine($" Succes,, your balance is : {balance} R.Y ");


                     break;
            case "4": 
                Console.WriteLine("Thank you for using our ATM . see you again ");
                isCorrect = false;
                break;
           default: Console.WriteLine("Invalid Option Try Again ");
               
                break;  
        }
    }
}
else
{
    Console.WriteLine("Your PIN Wrong");

}