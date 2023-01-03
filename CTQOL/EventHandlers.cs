using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events;
using Exiled.Events.EventArgs.Scp096;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Exiled.Events.EventArgs.Scp173;

namespace QOL
{
    //Event Hander class where all the events that are called are stored
    public static class EventHandlers
    {
        //When a player joins the server it sends them a private broadcast welcoming them.
        public static void OnVerified(VerifiedEventArgs ev)  //Note: use OnVerified instead of Onjoin so it can process itself
        {
            ev.Player.Broadcast(10, "<color=green>Welcome to Chaos Theory!\nJoin our discord: </color><color=yellow>discord.gg/ChaosSCP</color>");
        }

        //So tutorial cant Enrage 096
        public static void OnAddingTarget(AddingTargetEventArgs ev) //Use on adding target instead of on enrage so you can use the target variable
        {
            
            if(ev.Target.Role.Type == RoleTypeId.Tutorial)
            {
                ev.IsAllowed = false;
            }

        }

        // Stops tutorial from triggering 173
        public static void OnBlinking(BlinkingEventArgs ev)
        {
            bool canMove = true;
            foreach (Exiled.API.Features.Player player in ev.Targets)  // Iterates through Targets if they are tutorial they can move but keeps checking and if its not tutorial breaks and stops moving
            {
                if (player.Role.Type == RoleTypeId.Tutorial)
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                    break;
                }
            }
            if (canMove == false)
            {
                ev.IsAllowed = false;
            }
            Log.Info(ev.Player.Nickname + " is triggering 173");
        }

        //Remote keycard
        public static void OnInteractingDoor(InteractingDoorEventArgs ev)
        {

        }
        
    }
}