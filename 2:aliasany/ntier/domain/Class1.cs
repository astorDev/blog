using NullableInt = int?;

//global using Dto = (string Name, int Age);
public record Dto(string Name, int Age);

public interface IProvider
{
    Dto One();
}