using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events;
using Exiled.Events.EventArgs.Scp096;
using Exiled.Events.EventArgs.Player;
using static UnityEngine.GraphicsBuffer;

namespace QOL
{
    public class QOL : Plugin<Config>
    {
        public override string Name => "QOL";
        public override string Author => "TtroubleTT";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += EventHandlers.OnVerified;
            Scp096.AddingTarget += EventHandlers.OnAddingTarget;
            //Scp173.Blinking += EventHandlers.OnBlinking;
            //Exiled.Events.Handlers.Player.InteractingDoor += EventHandlers.OnInteractingDoor;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= EventHandlers.OnVerified;
            Scp096.AddingTarget -= EventHandlers.OnAddingTarget;
            //Scp173.Blinking -= EventHandlers.OnBlinking;
            //Exiled.Events.Handlers.Player.InteractingDoor -= EventHandlers.OnInteractingDoor;

            base.OnDisabled();
        }

    }


}
