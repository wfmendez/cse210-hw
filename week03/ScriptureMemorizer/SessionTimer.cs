using System;

public class SessionTimer
{
    private DateTime _startTime;
    private DateTime _endTime;

    public void Start()
    {
        _startTime = DateTime.Now;
    }

    public void Stop()
    {
        _endTime = DateTime.Now;
    }

    public int GetTotalSeconds()
    {
        TimeSpan timeTaken = _endTime - _startTime;
        return (int)timeTaken.TotalSeconds;
    }
}