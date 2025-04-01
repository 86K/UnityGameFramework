//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using UnityGameFramework.Runtime;

namespace StarForce
{
    public abstract class ProcedureBase : UnityGameFramework.Runtime.ProcedureBase
    {
        /// <summary>
        /// 流程所有者。
        /// 一般是默认流程，不指定名称。
        /// </summary>
        private IFsm<IProcedureManager> ProcedureOwner => GameEntry.Fsm.GetFsm<IProcedureManager>();

        /// <summary>
        /// 通过名称切换场景。
        /// </summary>
        /// <param name="sceneName">场景名</param>
        /// <param name="procedureType"></param>
        protected void ChangeScene(string sceneName, Type procedureType)
        {
            OnLeave(ProcedureOwner, false);
            // 下一个场景的名称
            ProcedureOwner.SetData<VarString>("NextSceneName", sceneName);
            // 下一个流程的类型
            ProcedureOwner.SetData<VarType>("NextProcedureType", procedureType);
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
