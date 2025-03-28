//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    [Serializable]
    public abstract class EntityData
    {
        [SerializeField]
        private int m_Id;

        [SerializeField]
        private int m_TypeId;

        [SerializeField]
        private Vector3 m_Position = Vector3.zero;

        [SerializeField]
        private Quaternion m_Rotation = Quaternion.identity;
        
        [SerializeField]
        private Vector3 m_Scale = Vector3.one;

        protected EntityData(int entityId, int typeId)
        {
            m_Id = entityId;
            m_TypeId = typeId;
        }

        /// <summary>
        /// 实体编号。
        /// 通过GameEntry.Entity.GenerateSerialId()生成。
        /// </summary>
        public int Id => m_Id;

        /// <summary>
        /// 实体类型编号。
        /// 配置表中填写的编号。
        /// </summary>
        public int TypeId => m_TypeId;

        /// <summary>
        /// 实体位置。
        /// </summary>
        public Vector3 Position
        {
            get => m_Position;
            set => m_Position = value;
        }

        /// <summary>
        /// 实体朝向。
        /// </summary>
        public Quaternion Rotation
        {
            get => m_Rotation;
            set => m_Rotation = value;
        }

        /// <summary>
        /// 实体缩放。
        /// </summary>
        public Vector3 Scale
        {
            get => m_Scale;
            set => m_Scale = value;
        }
    }
}
