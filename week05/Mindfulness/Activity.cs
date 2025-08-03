// Activity.cs
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        // Stub method
    }

    public void DisplayEndingMessage()
    {
        // Stub method
    }

    public void ShowSpinner(int seconds)
    {
        // Stub method
    }

    public void ShowCountDown(int seconds)
    {
        // Stub method
    }
}