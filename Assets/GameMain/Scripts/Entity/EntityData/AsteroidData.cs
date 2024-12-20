//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace StarForce
{
    [Serializable]
    public class AsteroidData : TargetableObjectData
    {
        [SerializeField]
        private int m_MaxHP;

        [SerializeField]
        private int m_Attack;

        [SerializeField]
        private float m_Speed;

        [SerializeField]
        private float m_AngularSpeed;

        [SerializeField]
        private int m_DeadEffectId;

        [SerializeField]
        private int m_DeadSoundId;

        public AsteroidData(int entityId, int typeId)
            : base(entityId, typeId, CampType.Neutral)
        {
            IDataTable<DRAsteroid> dtAsteroid = GameEntry.DataTable.GetDataTable<DRAsteroid>();
            DRAsteroid drAsteroid = dtAsteroid.GetDataRow(TypeId);
            if (drAsteroid == null)
            {
                return;
            }

            HP = m_MaxHP = drAsteroid.MaxHP;
            m_Attack = drAsteroid.Attack;
            m_Speed = drAsteroid.Speed;
            m_AngularSpeed = drAsteroid.AngularSpeed;
            m_DeadEffectId = drAsteroid.DeadEffectId;
            m_DeadSoundId = drAsteroid.DeadSoundId;
        }

        public override int MaxHP => m_MaxHP;

        public int Attack => m_Attack;

        public float Speed => m_Speed;

        public float AngularSpeed => m_AngularSpeed;

        public int DeadEffectId => m_DeadEffectId;

        public int DeadSoundId => m_DeadSoundId;
    }
}
