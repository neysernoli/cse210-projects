public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best thing that happened to you today?",
        "What would you like to remember about this day in the future?",
        "What did you learn today, either about yourself or about the world?",
        "Was there anything that made you laugh or smile today?",
        "What would you have liked to do today, but didn't get around to it?",
        "What important decisions did you make today?"
    };
    private Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}