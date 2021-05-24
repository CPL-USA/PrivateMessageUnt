using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrivateMessageUnt.Commands
{
    class CommandPrivateMessage : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "privatemsg";

        public string Help => string.Empty;

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string>() {"pm"};

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command) // /pm [nick] [message]
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (command.Length >= 2)
            {
                UnturnedPlayer toPlayer = UnturnedPlayer.FromName(command[0]);
                if (toPlayer != null)
                {
                    UnturnedChat.Say(player, PrivateMessage.Instance.Translate("command_private_message_successfully", command.GetParameterString(1)), Color.magenta);
                    ChatManager.serverSendMessage(PrivateMessage.Instance.Translate("command_private_message_to_player_successfully", player.CharacterName, command.GetParameterString(1)), Color.magenta, null, toPlayer.SteamPlayer(), EChatMode.GLOBAL, null, true);
                }
                else
                {
                    UnturnedChat.Say(player, PrivateMessage.Instance.Translate("command_private_message_player_not_found"), Color.red);
                    return;
                }
            }
            else
            {
                UnturnedChat.Say(player, PrivateMessage.Instance.Translate("command_private_message_help"), Color.red);
            }
          

        }
    }
}

