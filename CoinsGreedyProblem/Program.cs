using Models;

CoinCalculator calculator = new();
int amount = 562;

int result = calculator.CalculateMinCoins(amount);
Console.WriteLine(result);
