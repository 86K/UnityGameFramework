﻿using UnityEngine;
using UnityEngine.UI;

namespace StarForce
{
    public class UpdateResourceForm : MonoBehaviour
    {
        [SerializeField]
        private Text m_DescriptionText;

        [SerializeField]
        private Slider m_ProgressSlider;
        
        public void SetProgress(float progress, string description)
        {
            m_ProgressSlider.value = progress;
            m_DescriptionText.text = description;
        }
    }
}
