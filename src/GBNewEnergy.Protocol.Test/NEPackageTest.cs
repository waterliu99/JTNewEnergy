﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GBNewEnergy.Protocol.Extensions;

namespace GBNewEnergy.Protocol.Test
{
    public class NEPackageTest
    {
        [Fact]
        public void NEPackageConstructor()
        {
            byte[] header = "23 23 02 FE 54 45 53 54 32 30 31 38 30 34 31 36 30 30 30 30 31 01 02 25".ToHexBytes();
            byte[] body = "12 05 0F 0F 29 15 01 02  01 01 00 00 00 00 33 54 19 B1 23 06 58 01 00 06  9F 00 00 02 01 01 03 47 00 00 4E 20 47 10 D6 27  24 05 01 06 CA 3C 03 01 57 8E C3 06 01 38 0D 5C  01 01 0D 48 01 01 43 01 0B 42 07 00 00 00 00 00  00 00 00 00 08 01 01 19 B1 23 06 00 C0 00 01 C0  0D 48 0D 48 0D 48 0D 48 0D 52 0D 48 0D 48 0D 52  0D 52 0D 48 0D 48 0D 52 0D 48 0D 52 0D 52 0D 48  0D 52 0D 52 0D 52 0D 48 0D 52 0D 52 0D 48 0D 52  0D 48 0D 52 0D 48 0D 52 0D 52 0D 52 0D 52 0D 52  0D 48 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 48 0D 48 0D 48 0D 48 0D 48 0D 52  0D 48 0D 52 0D 48 0D 52 0D 48 0D 48 0D 48 0D 5C  0D 52 0D 52 0D 52 0D 5C 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 48 0D 48  0D 48 0D 52 0D 48 0D 52 0D 52 0D 52 0D 48 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 48 0D 48 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 48 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 48 0D 52 0D 48 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 48 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 48 0D 48 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52  0D 48 0D 52 0D 52 0D 52 0D 52 0D 48 0D 52 0D 52  0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 52 0D 48  0D 48 0D 48 0D 48 0D 52 0D 52 0D 48 0D 48 0D 48  0D 52 0D 48 0D 48 0D 48 0D 52 0D 48 0D 52 0D 52  09 01 01 00 48 43 43 43 43 43 43 43 43 43 43 42  43 42 42 42 42 42 43 42 42 42 42 42 42 42 43 42  42 42 43 42 42 42 42 42 42 42 42 42 42 42 42 42  42 43 42 42 43 42 42 42 42 42 42 42 42 43 42 42  43 43 43 42 43 43 43 43 43 43 43 43 43 48".ToHexBytes();
            NEPackage nEPackage = new NEPackage(header, body);
        }
    }
}