Csproj proj = new Csproj();


#region csproj

proj.Sdk = "Microsoft.NET.Sdk";

proj.TargetFramework = "net8.0";
proj.ImplicitUsingsEnabled = true;
proj.NullableEnabled = true;
proj.LangVersion = "preview";

#endregion csproj

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

public class Csproj {
    public string Sdk { get; set; } = "";
    public string LangVersion {get; set; } = "";
    public string TargetFramework { get; set; } = "";
    public bool NullableEnabled { get; set; } = true;
    public bool ImplicitUsingsEnabled { get; set; } = true;
    public List<string> ProjectReferences { get; set; } = new List<string>();
    public List<string> PackageReferences { get; set; } = new List<string>();
}