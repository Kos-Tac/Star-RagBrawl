﻿using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace StarRagBrawl
{
    [Serializable]
    public struct Speed : IComponentData
    {
        public float3 Value;
    }
}