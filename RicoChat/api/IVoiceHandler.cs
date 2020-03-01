﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RicoChat.api
{
    interface IVoiceHandler
    {
        bool SendData(byte[] buffer, int bytesRecorded);
        void Dispose();
    }
}
