﻿//------------------------------------------------------------
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
    public class BulletData : EntityData
    {
        [SerializeField]
        private int m_OwnerId;

        [SerializeField]
        private CampType m_OwnerCamp = CampType.Unknown;

        [SerializeField]
        private int m_Attack;

        [SerializeField]
        private float m_Speed;

        public BulletData(int entityId, int typeId, int ownerId, CampType ownerCamp, int attack, float speed)
            : base(entityId, typeId)
        {
            m_OwnerId = ownerId;
            m_OwnerCamp = ownerCamp;
            m_Attack = attack;
            m_Speed = speed;
        }

        public int OwnerId => m_OwnerId;

        public CampType OwnerCamp => m_OwnerCamp;

        public int Attack => m_Attack;

        public float Speed => m_Speed;
    }
}
