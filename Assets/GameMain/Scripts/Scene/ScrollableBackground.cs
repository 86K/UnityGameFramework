﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine;

namespace StarForce
{
    public class ScrollableBackground : MonoBehaviour
    {
        [SerializeField]
        private float m_ScrollSpeed = -0.25f;

        [SerializeField]
        private float m_TileSize = 30f;

        [SerializeField]
        private BoxCollider m_VisibleBoundary;

        [SerializeField]
        private BoxCollider m_PlayerMoveBoundary;

        [SerializeField]
        private BoxCollider m_EnemySpawnBoundary;

        private Transform m_CachedTransform;
        private Vector3 m_StartPosition = Vector3.zero;

        private void Start()
        {
            m_CachedTransform = transform;
            m_StartPosition = m_CachedTransform.position;
        }

        private void Update()
        {
            float newPosition = Mathf.Repeat(Time.time * m_ScrollSpeed, m_TileSize);
            m_CachedTransform.position = m_StartPosition + Vector3.forward * newPosition;
        }

        public BoxCollider VisibleBoundary => m_VisibleBoundary;

        public BoxCollider PlayerMoveBoundary => m_PlayerMoveBoundary;

        public BoxCollider EnemySpawnBoundary => m_EnemySpawnBoundary;
    }
}
