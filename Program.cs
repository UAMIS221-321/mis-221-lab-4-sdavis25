System.Console.WriteLine("Welcome to the Crimson Crust!");
int menuChoice = 0;
while(menuChoice != 4){
DisplayMenu();
menuChoice = GetMenuChoice();
RouteUser(menuChoice);
}


static void DisplayMenu(){
    System.Console.WriteLine("Here is our menu!\n 1. View plain pizza slice\n 2. View cheese pizza slice\n 3. View pepperoni pizza slice\n 4. Exit");
}

static int GetMenuChoice(){
    System.Console.WriteLine("Please enter your menu choice!");
    return int.Parse(Console.ReadLine());
}

static void RouteUser(int menuChoice){
    switch(menuChoice){
        case 1:
        DisplayPlainPizza();
        Pause();
        break;
        case 2:
        DisplayCheesePizza();
        Pause();
        break;
        case 3:
        DisplayPepperoniPizza();
        Pause();
        break;
        case 4:
        SayGoodBye();
        break;
        default:
        InvalidInputMessage();
        break;
    }
}

static void DisplayPlainPizza(){
    Random rnd = new Random();
        int number = rnd.Next(8,13);
        System.Console.WriteLine("Here's the plain pizza!");
        for(int i = number; i>0; i--){
        for(int j = 0; j<i; j++){
            System.Console.Write("*");
        }
        System.Console.WriteLine();
        }
}

static void DisplayCheesePizza(){
Random rnd = new Random();
        int number = rnd.Next(8,13);
        System.Console.WriteLine("Here's the Cheese pizza!");
        for(int i = number; i>0; i--){
        for(int j = 0; j<i; j++){
            if(i == number){
                Console.Write("*");
            }
            else if(j > 0 && j < i - 1){
                Console.Write("#");
            }
            else{
                System.Console.Write("*");
            }
        }
        System.Console.WriteLine();
        }
}

static void DisplayPepperoniPizza(){
    Random rnd = new Random();
        int number = rnd.Next(8,13);
        int numberOfPepperoni = rnd.Next(3,5);
        System.Console.WriteLine("Here's the Pepperoni pizza!");
        for(int i = number; i>0; i--){
        for(int j = 0; j<i; j++){
            if(i == number){
                Console.Write("*");
            }
            else if(j == numberOfPepperoni && i > 6){
                Console.Write("[]");
            }
            else if(j > 0 && j < i - 1){
                Console.Write("#");
            } 
            else{
                System.Console.Write("*");
            }
        }
        System.Console.WriteLine();
        }
}

static void SayGoodBye(){
    System.Console.WriteLine("GoodBye!");
}

static void InvalidInputMessage(){
    System.Console.WriteLine("That is not a valid menu choice :(");
    Pause();

}


static void Pause(){
    System.Console.WriteLine("Press any key to return to the main menu");
    Console.ReadKey();
    Console.Clear();
}