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

namespace QOl
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Config")]
        public bool Debug { get; set; } = true;
    }
}