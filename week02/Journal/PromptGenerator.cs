using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What did you learn today?",
        "What challenge did you face?",
        "Who inspired you today?",
        "What are you grateful for?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
