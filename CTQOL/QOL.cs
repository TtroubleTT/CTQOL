using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events;
using Exiled.Events.EventArgs.Scp096;
using Exiled.Events.EventArgs.Player;

namespace QOL
{
    public class QOL : Plugin<Config>
    {
        public override string Name => "QOL";
        public override string Author => "TtroubleTT";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Scp096.AddingTarget += EventHandlers.OnAddingTarget;
            Exiled.Events.Handlers.Player.Verified += EventHandlers.OnVerified;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Scp096.AddingTarget -= EventHandlers.OnAddingTarget;
            Exiled.Events.Handlers.Player.Verified -= EventHandlers.OnVerified;

            base.OnDisabled();
        }

    }


}
