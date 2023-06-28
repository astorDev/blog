using TitleFactory = System.Func<string, int, int, string>;

Console.WriteLine("Hello, World!");

record Person(string Name, int Age, int Gpa) {
    public void Print(TitleFactory titleFactory) {
        var title = titleFactory(this.Name, this.Age, this.Gpa);
        Console.WriteLine(title);
    }
}
