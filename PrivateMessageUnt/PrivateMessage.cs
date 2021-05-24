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
            {"command_private_message_help", "/pm [nick] [message]."},
            {"command_private_message_to_player_successfully", "<color=red>{0}</color> <color=white>пишет:</color> {1}."},
            {"command_private_message_successfully", "{0}" },
            {"command_private_message_player_not_found", "Игрок не найден." },
        };





    }
}
