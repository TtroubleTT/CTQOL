using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events;
using Exiled.Events.EventArgs.Scp096;
using Exiled.Events.EventArgs.Player;


namespace QOL
{
    public static class EventHandlers
    {
        public static void OnAddingTarget(AddingTargetEventArgs ev)
        {
            //if (ev.Target == Exiled.API.Features.Player.Get(PlayerRoles.RoleTypeId.Tutorial))
            Log.Info(ev.Target.Nickname + " has triggered 096");

        }

        public static void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(10, "<color=green>Welcome to Chaos Theory!\nFeel free to join our discord: </color><color=yellow>discord.gg/ChaosSCP</color>");
        }
    }
}