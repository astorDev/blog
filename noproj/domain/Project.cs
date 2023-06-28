namespace domain;

public class Greeter(IClock clock)
{
    public string Get() => clock.Time.TimeOfDay.Hours switch
    {
        <= 6 => "Good Night",
        <= 12 => "Good Morning",
        <= 18 => "Good Day",
        _ => "Good Evening",
    };
}

public interface IClock 
{
    public DateTime Time { get; }
}

public class Clock : IClock
{
    public DateTime Time => DateTime.Now;
}