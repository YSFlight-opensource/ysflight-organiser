﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Addons
{
    public class Aircraft
    {
        public String Name { get; protected set; }
        public String LstEntry { get; protected set; }

        public Aircraft(String lstEntry)
        {
            LstEntry = lstEntry;
        }
    }
}