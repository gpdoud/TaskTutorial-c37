using TaskTutorial;

Console.WriteLine("Ready!");

Utility utility = new() { max = 5_000_000_000, fact = 10 };

Task<int> tfactorial = Task<int>.Run(utility.Factorial);

tfactorial.Wait();

Console.WriteLine($"{utility.fact} factorial is {tfactorial.Result}");

Task<ulong> tsum2max = Task<ulong>.Run(utility.SumToMax);

//tsum2max.Wait();

Console.WriteLine($"Sum number from 1 to {utility.max} is {tsum2max.Result}");


/*
int a = 7;
int b = 3;

//Task<int> t1 = Task<int>.Run( () => a - (a / b * b) );
Task<int> t1 = new Task<int>(() => a - (a / b * b));

a = 11;
b = 3;

t1.Start();
t1.Wait();

Console.WriteLine($"{a} % {b} = {t1.Result}");
*/