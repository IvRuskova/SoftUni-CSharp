using CommandPattern.Core.Contracts;
using System.Windows.Input;

namespace CommandPattern.Core.Commands;

public class HelloCommand : Contracts.ICommand
{
    public string Execute(string[] args)
        => $"Hello, {args[0]}";
}