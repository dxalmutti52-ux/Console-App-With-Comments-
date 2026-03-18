using System;

class Program
{
    static void Main()
    {
        // -------------------------------
        // WHILE LOOP EXAMPLE
        // -------------------------------

        // Initialize a counter variable starting at 0
        int counter = 0;

        // The while loop will continue running as long as the condition (counter < 5) is true
        while (counter < 5)
        {
            // Print the current value of counter
            Console.WriteLine("While Loop Count: " + counter);

            // Increase counter by 1 each loop to avoid an infinite loop
            counter++;
        }


        // -------------------------------
        // DO-WHILE LOOP EXAMPLE
        // -------------------------------

        // Reset counter to 0 for the next loop
        int number = 0;

        // The do-while loop ALWAYS runs at least once before checking the condition
        do
        {
            // Print the current value of number
            Console.WriteLine("Do-While Loop Count: " + number);

            // Increase number by 1
            number++;

        } while (number < 3); // Loop continues as long as this condition is true


        // Keep the console window open so the user can read the output
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
