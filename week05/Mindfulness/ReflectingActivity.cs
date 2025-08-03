using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
        // Stub method
    }

    private string GetRandomPrompt()
    {
        return ""; // Stub
    }

    private string GetRandomQuestion()
    {
        return ""; // Stub
    }

    private void DisplayPrompt()
    {
        // Stub method
    }

    private void DisplayQuestions()
    {
        // Stub method
    }
}
