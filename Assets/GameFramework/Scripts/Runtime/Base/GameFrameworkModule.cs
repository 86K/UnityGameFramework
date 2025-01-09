//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 游戏框架模块抽象类。
    /// </summary>
    public abstract class GameFrameworkModule
    {
        /// <summary>
        /// 获取游戏框架模块优先级。
        /// </summary>
        /// <remarks>优先级较高的模块会优先轮询，并且关闭操作会后进行。</remarks>
<<<<<<< HEAD:Assets/GameFramework/Scripts/Runtime/Base/GameFrameworkModule.cs
        public virtual int Priority => 0;
=======
        internal virtual int Priority => 0;
>>>>>>> a50ae8f (1):Assets/GameFramework/Libraries/Base/GameFrameworkModule.cs

        /// <summary>
        /// 游戏框架模块轮询。
        /// </summary>
        /// <param name="elapseSeconds">逻辑流逝时间，以秒为单位。</param>
        /// <param name="realElapseSeconds">真实流逝时间，以秒为单位。</param>
        public abstract void Update(float elapseSeconds, float realElapseSeconds);

        /// <summary>
        /// 关闭并清理游戏框架模块。
        /// </summary>
        public abstract void Shutdown();
        
        // TODO
        // 等GameFramework定义的东西处理的差不多了，这三个修饰符还是要改回internal
    }
}
