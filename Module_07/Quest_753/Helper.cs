using System;

namespace Module_07.Quest_753;

public class Helper
{
    public static void Swap(ref int a, ref int b){
        (a, b) = (b, a);
    }
}
