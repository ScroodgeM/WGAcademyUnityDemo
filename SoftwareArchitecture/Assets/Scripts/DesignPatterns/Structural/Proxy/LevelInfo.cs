﻿
using System;

namespace WGADemo.DesignPatterns.Structural.Proxy
{
    [Serializable]
    public struct LevelInfo
    {
        public int number;
        public int floorsCount;
        public int[,] map;
    }
}
