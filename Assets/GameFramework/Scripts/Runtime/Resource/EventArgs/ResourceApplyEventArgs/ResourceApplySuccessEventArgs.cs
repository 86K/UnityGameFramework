//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 资源应用成功事件。
    /// </summary>
    public sealed class ResourceApplySuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 资源应用成功事件编号。
        /// </summary>
        public static readonly int EventId = typeof(ResourceApplySuccessEventArgs).GetHashCode();

        /// <summary>
        /// 初始化资源应用成功事件的新实例。
        /// </summary>
        public ResourceApplySuccessEventArgs()
        {
            Name = null;
            ApplyPath = null;
            ResourcePackPath = null;
            Length = 0;
            CompressedLength = 0;
        }

        /// <summary>
        /// 获取资源应用成功事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取资源名称。
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源应用后存放路径。
        /// </summary>
        public string ApplyPath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源包路径。
        /// </summary>
        public string ResourcePackPath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源大小。
        /// </summary>
        public int Length
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取压缩后大小。
        /// </summary>
        public int CompressedLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 创建资源应用成功事件。
        /// </summary>
        /// <param name="name">资源名称。</param>
        /// <param name="applyPath">资源应用后存放路径。</param>
        /// <param name="resourcePackPath">资源包路径。</param>
        /// <param name="length">资源大小。</param>
        /// <param name="compressedLength">压缩后大小。</param>
        /// <returns>创建的资源应用成功事件。</returns>
        public static ResourceApplySuccessEventArgs Create(string name, string applyPath, string resourcePackPath, int length, int compressedLength)
        {
            ResourceApplySuccessEventArgs resourceApplySuccessEventArgs = ReferencePool.Acquire<ResourceApplySuccessEventArgs>();
            resourceApplySuccessEventArgs.Name = name;
            resourceApplySuccessEventArgs.ApplyPath = applyPath;
            resourceApplySuccessEventArgs.ResourcePackPath = resourcePackPath;
            resourceApplySuccessEventArgs.Length = length;
            resourceApplySuccessEventArgs.CompressedLength = compressedLength;
            return resourceApplySuccessEventArgs;
        }
        
        /// <summary>
        /// 创建资源应用成功事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>创建的资源应用成功事件。</returns>
        public static ResourceApplySuccessEventArgs Create(ResourceApplySuccessEventArgs e)
        {
            ResourceApplySuccessEventArgs resourceApplySuccessEventArgs = ReferencePool.Acquire<ResourceApplySuccessEventArgs>();
            resourceApplySuccessEventArgs.Name = e.Name;
            resourceApplySuccessEventArgs.ApplyPath = e.ApplyPath;
            resourceApplySuccessEventArgs.ResourcePackPath = e.ResourcePackPath;
            resourceApplySuccessEventArgs.Length = e.Length;
            resourceApplySuccessEventArgs.CompressedLength = e.CompressedLength;
            return resourceApplySuccessEventArgs;
        }

        /// <summary>
        /// 清理资源应用成功事件。
        /// </summary>
        public override void Clear()
        {
            Name = null;
            ApplyPath = null;
            ResourcePackPath = null;
            Length = 0;
            CompressedLength = 0;
        }
    }
}
