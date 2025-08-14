using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore() => _score;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetDetails()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int earned = _goals[goalIndex].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points! Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}