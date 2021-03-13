﻿
namespace WGADemo.DesignPatterns.Creational.Multiton
{
    public interface IObjectPoolMember
    {
        bool InUse { get; }
        void MarkAsUsed();
        void Clear();
    }
}
