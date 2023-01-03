using Exiled.API.Features.Roles;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using MEC;
using Exiled.Events;
using Exiled.Events.Handlers;
using Player = Exiled.API.Features.Player;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Scp079;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace QOL
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Config.")]
        public bool Debug { get; set; } = true;

        [Description("Welcome message to server.")]
        public string MyWelcome { get; set; } = "<color=green>Welcome to Chaos Theory!\nJoin our discord: </color><color=yellow>discord.gg/ChaosSCP</color>";

        [Description("Tutorials don't trigger 096.")]
        public bool tutorial_notrigger_96 { get; set; } = true;

    }
    
}