﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoccerStats
{
    class PlayerComparer : IComparer<Player>
    {
        public int Compare([AllowNull] Player x, [AllowNull] Player y)
        {
            return x.PointsPerGame.CompareTo(y.PointsPerGame) * -1;
        }
    }
}
