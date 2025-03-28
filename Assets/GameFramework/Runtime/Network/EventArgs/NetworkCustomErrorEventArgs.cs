﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 用户自定义网络错误事件。
    /// </summary>
    public sealed class NetworkCustomErrorEventArgs : GameEventArgs
    {
        /// <summary>
        /// 用户自定义网络错误事件编号。
        /// </summary>
        public static readonly int EventId = typeof(NetworkCustomErrorEventArgs).GetHashCode();

        /// <summary>
        /// 初始化用户自定义网络错误事件的新实例。
        /// </summary>
        public NetworkCustomErrorEventArgs()
        {
            NetworkChannel = null;
            CustomErrorData = null;
        }

        /// <summary>
        /// 获取用户自定义网络错误事件编号。
        /// </summary>
        public override int Id => EventId;

        /// <summary>
        /// 获取网络频道。
        /// </summary>
        public INetworkChannel NetworkChannel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义错误数据。
        /// </summary>
        public object CustomErrorData
        {
            get;
            private set;
        }
        
        /// <summary>
        /// 创建用户自定义网络错误事件。
        /// </summary>
        /// <param name="networkChannel">网络频道。</param>
        /// <param name="customErrorData">用户自定义错误数据。</param>
        /// <returns>创建的用户自定义网络错误事件。</returns>
        public static NetworkCustomErrorEventArgs Create(INetworkChannel networkChannel, object customErrorData)
        {
            NetworkCustomErrorEventArgs networkCustomErrorEventArgs = ReferencePool.Acquire<NetworkCustomErrorEventArgs>();
            networkCustomErrorEventArgs.NetworkChannel = networkChannel;
            networkCustomErrorEventArgs.CustomErrorData = customErrorData;
            return networkCustomErrorEventArgs;
        }

        /// <summary>
        /// 创建用户自定义网络错误事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>创建的用户自定义网络错误事件。</returns>
        public static NetworkCustomErrorEventArgs Create(NetworkCustomErrorEventArgs e)
        {
            NetworkCustomErrorEventArgs networkCustomErrorEventArgs = ReferencePool.Acquire<NetworkCustomErrorEventArgs>();
            networkCustomErrorEventArgs.NetworkChannel = e.NetworkChannel;
            networkCustomErrorEventArgs.CustomErrorData = e.CustomErrorData;
            return networkCustomErrorEventArgs;
        }

        /// <summary>
        /// 清理用户自定义网络错误事件。
        /// </summary>
        public override void Clear()
        {
            NetworkChannel = null;
            CustomErrorData = null;
        }
    }
}
