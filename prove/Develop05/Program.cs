using System;

public class Program
{
    static void Main(string[] args)
    {
        int _score = 0;
        GoalManager start = new GoalManager(_score);
        start.Start();
    }
}