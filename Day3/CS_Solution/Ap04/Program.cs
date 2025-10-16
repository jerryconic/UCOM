using Ap04;

GuessGame g1 = new GuessGame();
g1.Start();
do
{
    g1.Guess();
} while (g1.GotAns());