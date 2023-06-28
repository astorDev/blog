Csproj project = new Csproj();

#region csproj

project.Sdk = "Microsoft.NET.Sdk.Web";
project.TargetFramework = "net8.0";
project.NullableEnabled = true;
project.ImplicitUsingsEnabled = true;
project.ProjectReferences.Add("../domain");
project.ProjectReferences.Add("../data");
project.PackageReferences.Add("Newtonsoft.Json:13.0.3");

#endregion

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();






























public class Csproj {
    public string Sdk { get; set; } = "";
    public string Version {get; set; } = "";
    public string TargetFramework { get; set; } = "";
    public bool NullableEnabled { get; set; } = true;
    public bool ImplicitUsingsEnabled { get; set; } = true;
    public List<string> ProjectReferences { get; set; } = new List<string>();
    public List<string> PackageReferences { get; set; } = new List<string>();


    public void Set(string[] args) 
    {

        #region csproj

        Sdk = "Microsoft.NET.Sdk.Web";
        TargetFramework = "net8.0";
        NullableEnabled = true;
        ImplicitUsingsEnabled = true;
        ProjectReferences.Add("../domain");
        ProjectReferences.Add("../data");
        PackageReferences.Add("Newtonsoft.Json:13.0.3");
        
        #endregion

        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();































    }
}