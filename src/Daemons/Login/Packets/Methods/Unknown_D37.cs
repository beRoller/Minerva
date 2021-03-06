﻿/*
    Copyright © 2010 The Divinity Project; 2013-2016 Dignity Team; 2016-2018 CentrinoGames.
    All rights reserved.
    http://board.thedivinityproject.com
    http://www.ragezone.com


    This file is part of Minerva.

    Minerva is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    Minerva is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Minerva.  If not, see <http://www.gnu.org/licenses/>.
*/

#region Includes

using System;
using System.Text;

#endregion

namespace Minerva
{
    partial class PacketProtocol
    {
        /*
        * UnknownCE9 Packet
        * -------------------------
        * Server2Client Structure:
        * 
        * UnknownCE9 -> E2 B7 0E 00 37 0D 00 00 00 00 00 00 00 00
        * 
        * ushort  : magic code
        * ushort  : size
        * ushort  : opcode
        * 
        * uint    : Unkn1
        * uint    : Unkn2
        */

        public static void Unknown_D37(PacketReader packet, PacketBuilder builder, ClientHandler client, EventHandler events)
        {

            builder.New(0xD37);
            {
                builder += 0;
                builder += 0;
            }

            client.Send(builder, "Unknown_D37");
        }
    }
}
