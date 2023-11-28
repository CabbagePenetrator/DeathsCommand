using PugMod;
using CoreLib;
using CoreLib.Commands;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class DeathsCommand : IMod
{
    public const string VERSION = "0.0.1";
    public const string NAME = "Deaths Command";
    public const string AUTHOR = "CabbagePenetrator";

    private LoadedMod modInfo;

    public void EarlyInit()
    {
        CoreLibMod.LoadModules(typeof(CommandsModule));

        modInfo = API.ModLoader.LoadedMods.FirstOrDefault(obj => obj.Handlers.Contains(this));

        if (modInfo == null)
        {
            Debug.Log($"[{NAME}]: Failed to load {NAME}!");
            return;
        }

        CommandsModule.AddCommands(modInfo.ModId, "Deaths Command");
    }

    public void Init()
    {
        //
    }

    public void ModObjectLoaded(Object obj)
    {
        //
    }

    public void Shutdown()
    {
        //
    }

    public void Update()
    {
        //
    }
}