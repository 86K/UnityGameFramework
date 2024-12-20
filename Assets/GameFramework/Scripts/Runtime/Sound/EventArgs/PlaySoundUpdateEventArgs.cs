//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 播放声音更新事件。
    /// </summary>
    public sealed class PlaySoundUpdateEventArgs : GameEventArgs
    {
        /// <summary>
        /// 播放声音更新事件编号。
        /// </summary>
        public static readonly int EventId = typeof(PlaySoundUpdateEventArgs).GetHashCode();

        /// <summary>
        /// 初始化播放声音更新事件的新实例。
        /// </summary>
        public PlaySoundUpdateEventArgs()
        {
            SerialId = 0;
            SoundAssetName = null;
            SoundGroupName = null;
            PlaySoundParams = null;
            Progress = 0f;
            BindingEntity = null;
            UserData = null;
        }

        /// <summary>
        /// 获取播放声音更新事件编号。
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
        /// 获取加载声音进度。
        /// </summary>
        public float Progress
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
        /// 创建播放声音更新事件。
        /// </summary>
        /// <param name="serialId">声音的序列编号。</param>
        /// <param name="soundAssetName">声音资源名称。</param>
        /// <param name="soundGroupName">声音组名称。</param>
        /// <param name="playSoundParams">播放声音参数。</param>
        /// <param name="progress">加载声音进度。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns>创建的播放声音更新事件。</returns>
        public static PlaySoundUpdateEventArgs Create(int serialId, string soundAssetName, string soundGroupName, PlaySoundParams playSoundParams, float progress, object userData)
        {
            PlaySoundUpdateEventArgs playSoundUpdateEventArgs = ReferencePool.Acquire<PlaySoundUpdateEventArgs>();
            playSoundUpdateEventArgs.SerialId = serialId;
            playSoundUpdateEventArgs.SoundAssetName = soundAssetName;
            playSoundUpdateEventArgs.SoundGroupName = soundGroupName;
            playSoundUpdateEventArgs.PlaySoundParams = playSoundParams;
            playSoundUpdateEventArgs.Progress = progress;
            playSoundUpdateEventArgs.UserData = userData;
            return playSoundUpdateEventArgs;
        }

        /// <summary>
        /// 创建播放声音更新事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>创建的播放声音更新事件。</returns>
        public static PlaySoundUpdateEventArgs Create(PlaySoundUpdateEventArgs e)
        {
            PlaySoundInfo playSoundInfo = (PlaySoundInfo)e.UserData;
            PlaySoundUpdateEventArgs playSoundUpdateEventArgs = ReferencePool.Acquire<PlaySoundUpdateEventArgs>();
            playSoundUpdateEventArgs.SerialId = e.SerialId;
            playSoundUpdateEventArgs.SoundAssetName = e.SoundAssetName;
            playSoundUpdateEventArgs.SoundGroupName = e.SoundGroupName;
            playSoundUpdateEventArgs.PlaySoundParams = e.PlaySoundParams;
            playSoundUpdateEventArgs.Progress = e.Progress;
            playSoundUpdateEventArgs.BindingEntity = playSoundInfo.BindingEntity;
            playSoundUpdateEventArgs.UserData = playSoundInfo.UserData;
            return playSoundUpdateEventArgs;
        }

        /// <summary>
        /// 清理播放声音更新事件。
        /// </summary>
        public override void Clear()
        {
            SerialId = 0;
            SoundAssetName = null;
            SoundGroupName = null;
            PlaySoundParams = null;
            Progress = 0f;
            BindingEntity = null;
            UserData = null;
        }
    }
}
