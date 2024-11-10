namespace TypeConversionsExample
{
    class TypeConversionsExample
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("=== Implicit Conversion ===");
            int smallNumber = 100;
            long largeNumber = smallNumber; // Implicit conversion from int to long
            Console.WriteLine($"Implicitly converted from int ({smallNumber}) to long ({largeNumber})");

            float piApproximation = 3.14f;
            double precisePi = piApproximation; // Implicit conversion from float to double
            Console.WriteLine($"Implicitly converted from float ({piApproximation}) to double ({precisePi})");

            // Explicit Conversion (Casting)
            Console.WriteLine("\n=== Explicit Conversion (Casting) ===");
            double price = 123.45;
            int roundedPrice = (int)price; // Explicit conversion from double to int
            Console.WriteLine($"Explicitly casted from double ({price}) to int ({roundedPrice})");

            long largeValue = 9876543210; // Value exceeds int.MaxValue
            int smallerValue = (int)largeValue; // Explicit conversion with possible data loss
            Console.WriteLine($"Original long value: {largeValue}, After casting to int: {smallerValue}");

            // Preventing Invalid Casts
            Console.WriteLine("\n=== Preventing Invalid Casts ===");
            if (largeValue >= int.MinValue && largeValue <= int.MaxValue)
            {
                int safeValue = (int)largeValue;
                Console.WriteLine($"Safely converted value: {safeValue}");
            }
            else
            {
                Console.WriteLine("Conversion not possible without data loss.");
            }

            // Helper Methods: Convert
            Console.WriteLine("\n=== Helper Methods: Convert ===");
            string ageInput = "30";
            int age = Convert.ToInt32(ageInput); // Convert string to int
            Console.WriteLine($"Converted string \"{ageInput}\" to int: {age}");

            string doubleInput = "123.45";
            double convertedDouble = Convert.ToDouble(doubleInput); // Convert string to double
            Console.WriteLine($"Converted string \"{doubleInput}\" to double: {convertedDouble}");

            // Helper Methods: Parse
            Console.WriteLine("\n=== Helper Methods: Parse ===");
            string numberInput = "500";
            int parsedNumber = int.Parse(numberInput); // Parse string to int
            Console.WriteLine($"Parsed string \"{numberInput}\" to int: {parsedNumber}");

            // Handling Errors with TryParse
            Console.WriteLine("\n=== Handling Errors with TryParse ===");
            string invalidInput = "abc";
            if (int.TryParse(invalidInput, out int result))
            {
                Console.WriteLine($"Successfully parsed \"{invalidInput}\" to int: {result}");
            }
            else
            {
                Console.WriteLine($"Failed to parse \"{invalidInput}\" as an integer.");
            }

            // Common Conversion Scenarios
            Console.WriteLine("\n=== Common Conversion Scenarios ===");
            int totalDistance = 150;
            double preciseDistance = totalDistance; // Implicit conversion from int to double
            Console.WriteLine($"Implicit conversion from int ({totalDistance}) to double ({preciseDistance})");

            double exactPrice = 49.99;
            int truncatedPrice = (int)exactPrice; // Explicit conversion from double to int
            Console.WriteLine($"Explicit conversion from double ({exactPrice}) to int ({truncatedPrice})");
        }
    }
}
