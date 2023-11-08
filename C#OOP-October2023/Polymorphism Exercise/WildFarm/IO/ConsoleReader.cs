using System;
using System.Reflection.PortableExecutable;
using WildFarm.IO.Interfaces;

namespace WildFarm.IO;

public class ConsoleReader : IReader
{
    public string ReadLine() => Console.ReadLine();
}