﻿using L2dotNET.Attributes;
using L2dotNET.model.player;

namespace L2dotNET.Commands.Admin
{
    [Command(CommandName = "teleport")]
    class AdminTeleport : AAdminCommand
    {
        protected internal override void Use(L2Player admin, string alias)
        {
            //int x = int.Parse(alias.Split(' ')[1]);
            //int y = int.Parse(alias.Split(' ')[2]);
            //int z = int.Parse(alias.Split(' ')[3]);
        }
    }
}