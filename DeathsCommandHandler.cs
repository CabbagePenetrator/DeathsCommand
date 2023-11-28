using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoreLib.Commands;

public class DeathsCommandHandler : IClientCommandHandler
{
    public CommandOutput Execute(string[] parameters)
    {
        return "You have died 2 times";
    }

    public string GetDescription()
    {
        return "Use /deaths to get the number of times you've died.";
    }

    public string[] GetTriggerNames()
    {
        return new[] {"deaths"};
    }
}