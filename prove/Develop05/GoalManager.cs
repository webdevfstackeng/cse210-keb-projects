using System;
using System.Collections.Generic;
using System.IO;

 
public class GoalManager
{
    public int _score;

    List<Goal> _goals = new();

    public GoalManager(int score)
    {  
        _score = 0;
    }

    public void Start()
    {
        while(true)
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
            Console.WriteLine("Menu Choices:");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine()); 
            if(choice == 1)       
            {
                CreateGoal();
            }
            else if(choice == 2)
            { 
                Goal checklistGoal = ChecklistGoal();
                Goal goal = (Goal)checklistGoal;
                goal.GetDetailsString();
            }
            else if(choice == 3)
            {
                SaveGoals();
            }
            else if(choice == 4)
            {
                LoadGoals();
            }
            else if(choice == 5)
            {
                RecordEvent();
            }

            else if(choice == 6)
            {
                return;
            }
            
            else
                Console.WriteLine("Invalid choice. Please try again.");
        }
        
    }

    // Display the player's current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"");
    }

    // Display all the goal names
    public void ListGoalNames()
    {
        Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine();
    }

    // Display all the details of each goal.
    public void ListGoalDetails()
    {
        GetDetailsString();
    }

    /* Give a menu to the user to select the kind of goal to create, ask the user to type in the goal information
    create the goal object, and add it to the goal list  */
    public void CreateGoal()
    {
        // List<Goal> _goals = new();
        int _target;
        int _bonus;
        
        ListGoalNames();
        Console.WriteLine("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        
        Console.Write("What is the name of your simple goal? ");
        string _shortName = Console.ReadLine();
        
        Console.Write("What is the short description of it? ");
        string _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
        

        switch(goalType)
        {            
            case 1:
                SimpleGoal simpleGoal = new(_shortName, _description, _points);
                _goals.Add(simpleGoal);
                break;
        
            case 2:
                EternalGoal eternalGoal = new(_shortName, _description, _points);
                _goals.Add(eternalGoal);
                break;    
            

            case 3:
                Console.WriteLine("How many times does this goal need to be achieved for a bonus? ");
                _target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for achieving it that many times? ");
                _bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistlGoal = new(_shortName, _description, _points, _target, _bonus);
                _goals.Add(checklistlGoal);
                break;   
        }

    }
 
    public void SaveGoals()
    {
        List<Goal> _goals = new();
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine().ToLower();
        string fileName = ($"{filename}.txt");

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine("Saving to the file:");

            foreach(Goal goal in _goals )
            {
                outputFile.WriteLine(goal);
            }
        }

    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename to load from? ");
        string filename = Console.ReadLine().ToLower();
        string fileName = ($"{filename}.txt");

        using(StreamReader inputFile = new StreamReader(fileName))
        {
            Console.WriteLine("Loading from the saved file:");

            while(!inputFile.EndOfStream )
            {
                string goal = inputFile.ReadLine();
                Console.WriteLine(goal);
            }
        }

    }

}
