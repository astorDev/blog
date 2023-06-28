# Post structure

1. Open Question / Provoking Thought
2. Context
3. Description

# Raw text

"We're about two C# versions away from a certification exam dedicated solely to object creation and initialization." (c) (YouTube comment)

🚀 C# 12 is on its way; let's dive into one of its most notable features: Primary Constructors for classes! 🎉

Primary constructors are not new for C#, but they have been available only for record types. Now, they are making their way to classes and structs! Primary constructor parameters of a class will act as class-scoped parameters rather than class members. This shift can greatly reduce class boilerplate. You can see in the picture below that even in the most trivial example, it saves a whopping 7!! lines of code. So, what can go wrong?

Well, as I already said, primary constructors in classes act very differently from primary constructors in records. In records, the constructor parameters become immutable, public class members as properties. And the class primary constructors are different in literally every aspect. They are mutable, class-scoped, and act as function parameters. As Nick Chapsas has pointed out in his video, that brings a lot of complication to C#. It seems that people in the comments doubt if we even need the feature for that cost.

Personally, I'm excited about this new constructor feature as I always strive to reduce code size. And this is definitely a step in the right direction. And although I understand the raised concerns, I believe it is worth it. I always cheer for C#, but the redundancy of declaring private fields and duplicating them as constructor parameters, and later assigning them has bothered me for a long time. I still think there's a long way for the feature to be polished enough, but I think it's headed in the right direction.

Let me know what you think! Click on the 👏 reaction, if you're as excited as I am. Or drop a comment if you are rather skeptical about the feature.