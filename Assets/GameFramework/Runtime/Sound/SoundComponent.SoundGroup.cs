﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public sealed partial class SoundComponent : GameFrameworkComponent
    {
        [Serializable]
        private sealed class SoundGroup
        {
            [SerializeField]
            private string m_Name;

            [SerializeField]
            private bool m_AvoidBeingReplacedBySamePriority;

            [SerializeField]
            private bool m_Mute;

            [SerializeField, Range(0f, 1f)]
            private float m_Volume = 1f;

            [SerializeField]
            private int m_AgentHelperCount = 1;

            public string Name => m_Name;

            public bool AvoidBeingReplacedBySamePriority => m_AvoidBeingReplacedBySamePriority;

            public bool Mute => m_Mute;

            public float Volume => m_Volume;

            public int AgentHelperCount => m_AgentHelperCount;
        }
    }
}
