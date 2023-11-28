using TwistedFizzBuzz;

try
{
    Console.WriteLine("----------- EXTRA TEST CASE #1 - NEGATIVE FIZZBUZZ -----------");

    Core program1 = new Core(-100, -1);
    program1.Calculate();

    Console.WriteLine("----------- EXTRA TEST CASE #2 - ONE-DIGIT RANGE -----------");

    Core program2 = new Core(5, 5);
    program2.Calculate();

    Console.WriteLine("----------- EXTRA TEST CASE #3 - MANY MULTIPLES -----------");

    Core program3 = new Core(30020, 30040, [new Element("Two", 2), new Element("Three", 3), new Element("Five", 5),
                                       new Element("Seven", 7), new Element("Eleven", 11), new Element("Thirteen", 13)]);
    program3.Calculate();

    Console.WriteLine("----------- EXTRA TEST CASE #4 - NEGATIVE MULTIPLE -----------");

    Core program4 = new Core(-10, -1, [new Element("MinusTwo", -2), new Element("MinusFive", -5)]);
    program4.Calculate();

    Console.WriteLine("----------- EXTRA TEST CASE #5 - MULTIPLE ZERO -----------");

    Core program5 = new Core(1, 10, [new Element("Zero", 0)]);
    program5.Calculate();

    Console.WriteLine("----------- EXTRA TEST CASE #6 - INVALID PARAMETERS -----------");

    Core program6 = new Core(1, 0);
    program6.Calculate();
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
