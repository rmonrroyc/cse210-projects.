public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;
    private bool _completed;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
        _completed = false;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _completed = true;
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _completed ? "[X]" : $"[ ] Completed {_currentCount}/{_targetCount} times";
    }
}