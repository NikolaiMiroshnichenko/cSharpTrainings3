﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface ISportsPlane : IPlane
    {
        int CrewNumber{ get; }
        string Airdrop();
    }
}
