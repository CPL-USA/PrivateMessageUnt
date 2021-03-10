using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrivateMessageUnt.Commands
{
    class CommandPM : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "pm";

        public string Help => string.Empty;

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (command.Length<=1)
            {
                UnturnedChat.Say(player, PrivateMessage.Instance.Translate("command_pm_error"), Color.red);
            }
            else
            {
                UnturnedPlayer player2 = UnturnedPlayer.FromName(command[0]);
                if (player2 == null)
                {
                    UnturnedChat.Say(player, PrivateMessage.Instance.Translate("command_pm_player_not_found", command[0]), Color.red);
                    return;
                }
                UnturnedChat.Say(player2, PrivateMessage.Instance.Translate("command_pm_delivered", player.CharacterName, command[1]), Color.magenta);
            }


        }
    }
}
