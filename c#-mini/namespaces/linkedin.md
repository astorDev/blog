## The thing you probably didn't know about C# namespaces :alien:

Namespaces were always the thing you meet first when doing any C#. :raised_hand_with_fingers_splayed:  
So, from "Hello, World!" until the AI revolt, right?

Not really! Here comes C# 9 and it's just

```csharp
System.Console.WriteLine("Hello, World!")
```

with C# 10 further simplifying it to 

```csharp
Console.WriteLine("Hello, World")
```

Alright, so this all is just about the new feature: top-level statements, right? Bear with me, do you know you can also do:

```csharp
public partial class Program {}
```

But what namespace is it in? Is it somehow inferred from the project name? Turns out it's not in any namespace! Wait... Is it legal? Surprisingly enough, it is! What's even more shocking is that it was legal virtually from the beginning of C#! And without a namespace, the class is just visible without any `using`.

What I still don't understand is: Why isn't it common practice to have classes without namespaces. I get why you'll want to skip, this for a public API. But here's an extensive list of places where you may use it:

- **ASP.NET Controllers** - you hardly will reference it somewhere. Why would you need a namespaces
- **Tests** - We can just group them by project name. Why declare a namespace?
- **Domain Layer** - Let's be honest the layer most likely will be used in a single solution where it's unlikely to have classes with the same name. So why overhead!

So, as you may see I'm essentially thinking of removing the namespaces from most of the places - practically everything but public libraries. But I understand that sounds extreme. Did you know you can have classes without namespaces? Do you think you'll omit namespaces in some parts of your code?

- :bar_chart: Did you know you can have classes without namespaces?
    - ⚪ Yes, I omit namespaces sometimes
    - ⚪ No, I consider omitting namespaces now
    - ⚪ Omitting namespaces is always a bad idea!




