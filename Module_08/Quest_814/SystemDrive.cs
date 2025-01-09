using System;

namespace Module_08.Quest_814;

/// <summary>
/// Класс системного диска
/// </summary>
/// <param name="name"></param>
/// <param name="totalSpace"></param>
/// <param name="freeSpace"></param>
/// <param name="reservedSpace"></param>
public class SystemDrive(string name, long totalSpace, long freeSpace, long reservedSpace) : Drive(name, totalSpace, freeSpace)
{
    public long ReservedSpace { get; } = reservedSpace;
}
