# Brief

- The new C# feature you probably don't need
- This post is a continuation of posts dedicated to C# 12 features
- Now you can alias tuples, arrays, nullable, and pointers.
- I find no real-life scenario where you would use it
- For example, instead of tuples, just use records
- It's good C# team is filling the gaps, but kind of useless.
- If you know an example of where you may want to use it - leave a comment below
- If you agree with me - like the post

# Test

The New C# Feature You Probably Don't Need! 😱

Continuing our series on C# 12 features, let's delve into an intriguing addition: Alias any type. With this feature, the C# language team removes the limitation of aliases to be allowed only for named types. So now, one can use it to alias: tuples types, array types, and nullable value types in short form. But here's the catch, do we really need it? 🤔

Let's start one by one:
- **using DatabaseInt = int?**. Why would one do that? It's essentially an extra code producing extra code and confusing people with a new type. I think we should avoid this.
- **using IntArray = int[]**- The same here: Why?
- **using Point = (int X, int Y)**. This one is more complicated. It seems tempting to essentially declare a new short type in one line. So, what's wrong? Well, the alias will only be scoped to a file or a project if used with the "global" keyword. The good news is **record Point(int X, int Y)** will accomplish practically the same but can be reused in multiple projects.

In the end, I would like to still cheer for the C# team for making the alias feature complete, despite the fact I don't see a real-life scenario for using it.

Have an example where the new aliases shine? Please, share it in the 💬 below! Or hit the 👍 button if you agree with me! 

#csharp #dotnet #csharpdeveloper #csharpdotnet

![image](/showcase.png)