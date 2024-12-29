using System;

namespace Module_07.Quest_7110;

public class DerivedClass: BaseClass
{
    public string Description;
    public int Counter;
    public DerivedClass(string Name, string Description, int Counter) : this(Name, Description) {
        this.Counter = Counter;
    }

    public DerivedClass (string Name, string Description) : base(Name) {
        this.Description = Description;
    }
}
