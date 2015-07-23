﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.spacepuppy.Serialization
{
    public interface IUnityData
    {

        int Size { get; }

        void Clear();
        void SetData(System.IO.Stream data, UnityEngine.Object[] refs);
        void GetData(System.IO.Stream data, out UnityEngine.Object[] refs);

    }
}