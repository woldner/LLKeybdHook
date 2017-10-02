﻿using System;

namespace jwldnr.LLKeybdHook.App.WinApi
{
    [Flags]
    internal enum KEYBDHOOKF : uint
    {
        LLKHF_EXTENDED = 0x01,
        LLKHF_LOWER_IL_INJECTED = 0x02,
        LLKHF_INJECTED = 0x10,
        LLKHF_ALTDOWN = 0x20,
        LLKHF_UP = 0x80
    }
}