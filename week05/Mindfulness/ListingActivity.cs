// ListingActivity.cs
using System.Collections.Generic;

public class ListingActivity : Activity
{

    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
    }

    public void Run()
    {
        // Stub method
    }

    private string GetRandomPrompt()
    {
        return ""; // Stub
    }

    private List<string> GetListFromUser()
    {
        return new List<string>(); // Stub
    }
}