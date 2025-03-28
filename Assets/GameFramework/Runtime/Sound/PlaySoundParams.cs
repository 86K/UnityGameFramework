﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 播放声音参数。
    /// </summary>
    public sealed class PlaySoundParams : IReference
    {
        private bool m_Referenced;
        private float m_Time;
        private bool m_MuteInSoundGroup;
        private bool m_Loop;
        private int m_Priority;
        private float m_VolumeInSoundGroup;
        private float m_FadeInSeconds;
        private float m_Pitch;
        private float m_PanStereo;
        private float m_SpatialBlend;
        private float m_MaxDistance;
        private float m_DopplerLevel;

        /// <summary>
        /// 初始化播放声音参数的新实例。
        /// </summary>
        public PlaySoundParams()
        {
            m_Referenced = false;
            m_Time = 0f;
            m_MuteInSoundGroup = false;
            m_Loop = false;
            m_Priority = 0;
            m_VolumeInSoundGroup = 1f;
            m_FadeInSeconds = 0f;
            m_Pitch = 1f;
            m_PanStereo = 0f;
            m_SpatialBlend = 0f;
            m_MaxDistance = 100f;
            m_DopplerLevel = 1f;
        }

        /// <summary>
        /// 获取或设置播放位置。
        /// </summary>
        public float Time
        {
            get => m_Time;
            set => m_Time = value;
        }

        /// <summary>
        /// 获取或设置在声音组内是否静音。
        /// </summary>
        public bool MuteInSoundGroup
        {
            get => m_MuteInSoundGroup;
            set => m_MuteInSoundGroup = value;
        }

        /// <summary>
        /// 获取或设置是否循环播放。
        /// </summary>
        public bool Loop
        {
            get => m_Loop;
            set => m_Loop = value;
        }

        /// <summary>
        /// 获取或设置声音优先级。
        /// </summary>
        public int Priority
        {
            get => m_Priority;
            set => m_Priority = value;
        }

        /// <summary>
        /// 获取或设置在声音组内音量大小。
        /// </summary>
        public float VolumeInSoundGroup
        {
            get => m_VolumeInSoundGroup;
            set => m_VolumeInSoundGroup = value;
        }

        /// <summary>
        /// 获取或设置声音淡入时间，以秒为单位。
        /// </summary>
        public float FadeInSeconds
        {
            get => m_FadeInSeconds;
            set => m_FadeInSeconds = value;
        }

        /// <summary>
        /// 获取或设置声音音调。
        /// </summary>
        public float Pitch
        {
            get => m_Pitch;
            set => m_Pitch = value;
        }

        /// <summary>
        /// 获取或设置声音立体声声相。
        /// </summary>
        public float PanStereo
        {
            get => m_PanStereo;
            set => m_PanStereo = value;
        }

        /// <summary>
        /// 获取或设置声音空间混合量。
        /// </summary>
        public float SpatialBlend
        {
            get => m_SpatialBlend;
            set => m_SpatialBlend = value;
        }

        /// <summary>
        /// 获取或设置声音最大距离。
        /// </summary>
        public float MaxDistance
        {
            get => m_MaxDistance;
            set => m_MaxDistance = value;
        }

        /// <summary>
        /// 获取或设置声音多普勒等级。
        /// </summary>
        public float DopplerLevel
        {
            get => m_DopplerLevel;
            set => m_DopplerLevel = value;
        }

        internal bool Referenced => m_Referenced;

        /// <summary>
        /// 创建播放声音参数。
        /// </summary>
        /// <returns>创建的播放声音参数。</returns>
        public static PlaySoundParams Create()
        {
            PlaySoundParams playSoundParams = ReferencePool.Acquire<PlaySoundParams>();
            playSoundParams.m_Referenced = true;
            return playSoundParams;
        }

        /// <summary>
        /// 清理播放声音参数。
        /// </summary>
        public void Clear()
        {
            m_Time = 0f;
            m_MuteInSoundGroup = false;
            m_Loop = false;
            m_Priority = 0;
            m_VolumeInSoundGroup = 1f;
            m_FadeInSeconds = 0f;
            m_Pitch = 1f;
            m_PanStereo = 0f;
            m_SpatialBlend = 0f;
            m_MaxDistance = 100f;
            m_DopplerLevel = 1f;
        }
    }
}
