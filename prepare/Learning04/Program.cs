using System;

class Program
{
    static void Main(string[] args)
    {
        // Super class Assignment object creation
        Assignment assignment = new Assignment("John James", "Basic Algebra"); 
        Console.WriteLine(assignment.GetSummary());

        // Sub  class MathAssignment object creation
        MathAssignment MathAssign = new MathAssignment("Dan Jones", "Addition", "9.2", "10-12");
        Console.WriteLine(MathAssign.GetSummary());
        Console.WriteLine(MathAssign.GetHomeworkList());

         // Sub  class WritingAssignment object creation
        WritingAssignment writingAssign = new WritingAssignment("Jane Well", "Indiginous Knowledge", "Should it Benefit Affected Communities? ");
        Console.WriteLine(writingAssign.GetSummary());
         Console.WriteLine(writingAssign.GetWritingInformation());
         
    }
    
}