class Calculator { 
    static void Main() {
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Enter an expression, like '1 + 1':");

        string input = Console.ReadLine();
        if (input == null) {
            Console.WriteLine("please enter a valid number");
            return;
        }

        string[] tokens = input.Split(' ');

        if (tokens.Length != 3) {
            Console.WriteLine("Invalid input format. Please enter an expression like 1+1 lmfao ");
        }

        double num1, num2;

        if(!double.TryParse(tokens[0], out num1) || !double.TryParse(tokens[2], out num2)) {
            Console.WriteLine("Invalid numbers entered. Please enter valid numeric values.");
            return;
        }

        string op = tokens[1];
        double result;

        switch (op) {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0) {
                    Console.WriteLine("cant devide by 0");
                    return;
                } else {
                    result = num1 / num2;
                    break;
                }
            default:
                Console.WriteLine("Invalid operator. Invalid operator. Please use one of '+', '-', '*', '/' :3 ");
                return;
                
        }

        Console.WriteLine($"Result: {result}");

    }
}