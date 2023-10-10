using System;
 
class Program
{
    // I have created and accessed prompts, questions and listings from text files.
    static void Main(string[] args)
    {
        
        double _duration;
        int choice;
        
        while(true){
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            //Console.Clear();
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());
 
            if (choice == 1)
            {
                // Welcome message
                Console.WriteLine($"Welcome to the Breathing Activity.");

                // Activity description
                Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly." + 
                "Clear your mind and focus on breathing.");
                Console.WriteLine(); // format spacing.

                // Prompt for activity duration.
                Console.Write("How long in seconds, would you like for your session? ");
                _duration = Convert.ToDouble(Console.ReadLine()); // Read in the activity duration in seconds

                BreathingActivity breathing = new BreathingActivity(_duration);  
                breathing.RunActivity(); // Run the activity

                breathing.DisplayEndingMessage();  // Display ending message
            }
            else if(choice == 2)
            {
                Console.WriteLine($"Welcome to the Reflection Activity.");
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine();
                Console.Write("How long in seconds, would you like for your session? ");
                _duration = Convert.ToDouble(Console.ReadLine());

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(_duration);

                ReflectionActivity reflection = new ReflectionActivity(_duration);
                List<string> responses = new List<string>();
                while (true)   
                {
                    if (DateTime.Now >= endTime)
                    {
                        break;
                    }

                    Console.WriteLine("Consider the following prompt:");
                    string reflectionPrompt = reflection.ReflectionPrompts();
                    Console.WriteLine(reflectionPrompt);
                
                    Console.WriteLine("When you have something in your mind, press enter to continue.");
                    Console.ReadLine();
                    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

                    string randQuestionPrompt = reflection.ReflectionQuestionnaire();
                    Console.WriteLine(randQuestionPrompt);

                    Activity pausewithspinner = new Activity(_duration);
                    pausewithspinner.PauseWithSpinner();
                    Console.Write("> ");
                    string questionResponse = Console.ReadLine();
                    responses.Add(questionResponse);
                    
                    //reflection.RunActivity();
                }
                Console.WriteLine($"Number of responses: {responses.Count}");
                reflection.DisplayEndingMessage();
            }
            
            else if (choice == 3)
            {
                Console.WriteLine("Welcome to the Listing Activity.");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine();
                Console.Write("How long in seconds, would you like for your session? ");
                _duration = Convert.ToDouble(Console.ReadLine());
                ListingActivity listing = new ListingActivity(_duration);

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(_duration);

                List<string> listingquestionresponses = new List<string>();
                Console.WriteLine("List as many responses as you can to the following prompts:");
                while(true)
                {  
                    if (DateTime.Now >= endTime)
                        {
                            break;
                        }
                     
                    string randomPromptQuestion = listing.GenerateListingPrompts();
                    Console.WriteLine(randomPromptQuestion);
                    Console.Write("> ");
                    string questionResponse = Console.ReadLine();
                    listingquestionresponses.Add(questionResponse);
                    Console.Write("Please keep listing...!");
                    Activity pausewithcountimer = new Activity(_duration);
                    pausewithcountimer.PauseCountdownTimer(5);   
                }
                Console.WriteLine($"Number of responses: {listingquestionresponses.Count}");
                listing.DisplayEndingMessage(); 
            }

            else if(choice == 4)
            {
                Console.WriteLine("We hope the Mindfulness Activity was time well spent. Thank you!!");
                break;
            }
            else
                Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
