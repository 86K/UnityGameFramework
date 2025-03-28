﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 播放声音时加载依赖资源事件。
    /// </summary>
    public sealed class PlaySoundDependencyAssetEventArgs : GameEventArgs
    {
        /// <summary>
        /// 播放声音时加载依赖资源事件编号。
        /// </summary>
        public static readonly int EventId = typeof(PlaySoundDependencyAssetEventArgs).GetHashCode();

        /// <summary>
        /// 初始化播放声音时加载依赖资源事件的新实例。
        /// </summary>
        public PlaySoundDependencyAssetEventArgs()
        {
            SerialId = 0;
            SoundAssetName = null;
            SoundGroupName = null;
            PlaySoundParams = null;
            DependencyAssetName = null;
            LoadedCount = 0;
            TotalCount = 0;
            BindingEntity = null;
            UserData = null;
        }

        /// <summary>
        /// 获取播放声音时加载依赖资源事件编号。
        /// </summary>
        public override int Id => EventId;

        /// <summary>
        /// 获取声音的序列编号。
        /// </summary>
        public int SerialId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取声音资源名称。
        /// </summary>
        public string SoundAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取声音组名称。
        /// </summary>
        public string SoundGroupName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取播放声音参数。
        /// </summary>
        public PlaySoundParams PlaySoundParams
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取被加载的依赖资源名称。
        /// </summary>
        public string DependencyAssetName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取当前已加载依赖资源数量。
        /// </summary>
        public int LoadedCount
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取总共加载依赖资源数量。
        /// </summary>
        public int TotalCount
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取声音绑定的实体。
        /// </summary>
        public Entity BindingEntity
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据。
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }
        
        /// <summary>
        /// 创建播放声音时加载依赖资源事件。
        /// </summary>
        /// <param name="serialId">声音的序列编号。</param>
        /// <param name="soundAssetName">声音资源名称。</param>
        /// <param name="soundGroupName">声音组名称。</param>
        /// <param name="playSoundParams">播放声音参数。</param>
        /// <param name="dependencyAssetName">被加载的依赖资源名称。</param>
        /// <param name="loadedCount">当前已加载依赖资源数量。</param>
        /// <param name="totalCount">总共加载依赖资源数量。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns>创建的播放声音时加载依赖资源事件。</returns>
        public static PlaySoundDependencyAssetEventArgs Create(int serialId, string soundAssetName, string soundGroupName, PlaySoundParams playSoundParams, string dependencyAssetName, int loadedCount, int totalCount, object userData)
        {
            PlaySoundDependencyAssetEventArgs playSoundDependencyAssetEventArgs = ReferencePool.Acquire<PlaySoundDependencyAssetEventArgs>();
            playSoundDependencyAssetEventArgs.SerialId = serialId;
            playSoundDependencyAssetEventArgs.SoundAssetName = soundAssetName;
            playSoundDependencyAssetEventArgs.SoundGroupName = soundGroupName;
            playSoundDependencyAssetEventArgs.PlaySoundParams = playSoundParams;
            playSoundDependencyAssetEventArgs.DependencyAssetName = dependencyAssetName;
            playSoundDependencyAssetEventArgs.LoadedCount = loadedCount;
            playSoundDependencyAssetEventArgs.TotalCount = totalCount;
            playSoundDependencyAssetEventArgs.UserData = userData;
            return playSoundDependencyAssetEventArgs;
        }

        /// <summary>
        /// 创建播放声音时加载依赖资源事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>创建的播放声音时加载依赖资源事件。</returns>
        public static PlaySoundDependencyAssetEventArgs Create(PlaySoundDependencyAssetEventArgs e)
        {
            PlaySoundInfo playSoundInfo = (PlaySoundInfo)e.UserData;
            PlaySoundDependencyAssetEventArgs playSoundDependencyAssetEventArgs = ReferencePool.Acquire<PlaySoundDependencyAssetEventArgs>();
            playSoundDependencyAssetEventArgs.SerialId = e.SerialId;
            playSoundDependencyAssetEventArgs.SoundAssetName = e.SoundAssetName;
            playSoundDependencyAssetEventArgs.SoundGroupName = e.SoundGroupName;
            playSoundDependencyAssetEventArgs.PlaySoundParams = e.PlaySoundParams;
            playSoundDependencyAssetEventArgs.DependencyAssetName = e.DependencyAssetName;
            playSoundDependencyAssetEventArgs.LoadedCount = e.LoadedCount;
            playSoundDependencyAssetEventArgs.TotalCount = e.TotalCount;
            playSoundDependencyAssetEventArgs.BindingEntity = playSoundInfo.BindingEntity;
            playSoundDependencyAssetEventArgs.UserData = playSoundInfo.UserData;
            return playSoundDependencyAssetEventArgs;
        }

        /// <summary>
        /// 清理播放声音时加载依赖资源事件。
        /// </summary>
        public override void Clear()
        {
            SerialId = 0;
            SoundAssetName = null;
            SoundGroupName = null;
            PlaySoundParams = null;
            DependencyAssetName = null;
            LoadedCount = 0;
            TotalCount = 0;
            BindingEntity = null;
            UserData = null;
        }
    }
}
