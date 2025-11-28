namespace Crypt;

public class App
{
    public void Run()
    {
        var password = "Password123!";
        var cryptedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        Console.WriteLine($"clear text: {password}, Crypted: {cryptedPassword}");
        while (true)
        {
            Console.Write("Enter password");
            var guess = Console.ReadLine();
            if (BCrypt.Net.BCrypt.Verify(guess, cryptedPassword))
            {
                Console.WriteLine("Password ok");
                break;
            }
            else
            {
                Console.WriteLine("Verification failed - try again");
            }
        }
    }
}