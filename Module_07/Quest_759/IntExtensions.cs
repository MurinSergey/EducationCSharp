using System;

namespace Module_07.Quest_759;

static class IntExtensions
{
    public static int GetNegative(this int source){
        return source > 0 ? Swap(source) : source;
    }

    public static int GetPositive(this int source){
        return source < 0 ? Swap(source) : source;
    }

    private static int Swap (int num){
        return -1 * num;
    }
}
