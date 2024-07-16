/*Dice 
 6 faces ,
 rolls dice*/

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);



GameResult gameResult = guessingGame.Play();

Console.ReadLine();


class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;
    
    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }


    public GameResult Play()
    {
        var diceRollResult = _dice.RollDice();
        Console.WriteLine(
            $"Dice rolled. Guess what number it shows in {InitialTries} tries");
        var triesLeft = InitialTries;
        while (triesLeft>0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");
            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }

            --triesLeft;


        }
        return GameResult.Loss;

    }

  
}

public enum GameResult
{
    Victory ,
    Loss 
}

public static class ConsoleReader
{
    public  static int ReadInteger(string message)
    {
        int result = 0;

        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

public class Dice
{
    private Random _random = new Random();
    private const int NumberOfFaces = 6;

    public Dice(Random random)
    {
        _random = random;
    }
    public int RollDice()
    {
       return _random.Next(1, NumberOfFaces + 1);
    }
}

