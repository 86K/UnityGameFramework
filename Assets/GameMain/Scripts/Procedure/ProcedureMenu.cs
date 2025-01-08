//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityGameFramework.Runtime;
using ProcedureOwner = UnityGameFramework.Runtime.IFsm<UnityGameFramework.Runtime.IProcedureManager>;

namespace StarForce
{
    public class ProcedureMenu : ProcedureBase
    {
        private bool m_StartGame;
        private MenuForm m_MenuForm;

        public override bool UseNativeDialog => false;

        public void StartGame()
        {
            m_StartGame = true;
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            
            m_StartGame = false;
            GameEntry.UI.OpenUIForm((int)UIFormId.MenuForm);
        }
        
        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if (m_StartGame)
            {
                procedureOwner.SetData<VarByte>("GameMode", (byte)GameMode.Survival);
                
                ChangeScene(GameEntry.Config.GetInt("Scene.Main"));
            }
        }
    }
}
