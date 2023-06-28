
using NullableInt = int?;
using Strings = string[];
record Point(int X, int Y);


class Caller {
    void Do(NullableInt nin, Strings strs, Point point);
}