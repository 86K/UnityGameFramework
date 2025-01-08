//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityGameFramework.Runtime;

namespace StarForce
{
    public abstract class ProcedureBase : UnityGameFramework.Runtime.ProcedureBase
    {
        // 获取流程是否使用原生对话框
        // 在一些特殊的流程（如游戏逻辑对话框资源更新完成前的流程）中，可以考虑调用原生对话框进行消息提示行为
        public abstract bool UseNativeDialog
        {
            get;
        }

        /// <summary>
        /// 流程所有者。
        /// 一般是默认流程，不指定名称。
        /// </summary>
        private IFsm<IProcedureManager> ProcedureOwner => GameEntry.Fsm.GetFsm<IProcedureManager>();

        /// <summary>
        /// 通过名称切换场景。
        /// </summary>
        /// <param name="sceneName">比如："Scene.Menu"</param>
        protected void ChangeScene(string sceneName)
        {
            OnLeave(ProcedureOwner, false);
            ProcedureOwner.SetData<VarInt32>("NextSceneId", GameEntry.Config.GetInt(sceneName));
            ChangeState<ProcedureChangeScene>(ProcedureOwner);
        }
        
        /// <summary>
        /// 通过Scene.txt配置表中配置的场景id切换场景。
        /// </summary>
        /// <param name="sceneId">场景id。</param>
        protected void ChangeScene(int sceneId)
        {
            OnLeave(ProcedureOwner, false);
            ProcedureOwner.SetData<VarInt32>("NextSceneId", sceneId);
            ChangeState<ProcedureChangeScene>(ProcedureOwner);
        }

        /// <summary>
        /// 根据指定的流程类型切换流程。
        /// </summary>
        /// <typeparam name="T">流程类型</typeparam>
        protected void ChangeProcedure<T>() where T : ProcedureBase
        {
            OnLeave(ProcedureOwner, false);
            ChangeState<T>(ProcedureOwner);
        }
    }
}
