using CommandPattern.Core.Contracts;
using System;
using System.Windows.Input;

namespace CommandPattern.Core.Commands;

public class ExitCommand : Contracts.ICommand
{
    private const int DefaultExitCode = 0;

    public string Execute(string[] args)
    {
        Environment.Exit(DefaultExitCode);

        return null;
    }
}