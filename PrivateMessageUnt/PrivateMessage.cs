using Rocket.API.Collections;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateMessageUnt
{
    public class PrivateMessage : RocketPlugin
    {
        public static PrivateMessage Instance;


        protected override void Load()
        {
            Instance = this;
        }

        protected override void Unload()
        {

        }



        public override TranslationList DefaultTranslations => new TranslationList()
        {
            {"command_pm_error", "/pm [nickname] [message]"},
            {"command_pm_delivered", "{0} пишет: {1}"},
            {"command_pm_player_not_found", "{0} не найден." },
        };





    }
}
