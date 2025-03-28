﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public sealed partial class DebuggerComponent : GameFrameworkComponent
    {
        private sealed class SettingsWindow : ScrollableDebuggerWindowBase
        {
            private DebuggerComponent m_DebuggerComponent;
            private SettingComponent m_SettingComponent;
            private float m_LastIconX;
            private float m_LastIconY;
            private float m_LastWindowX;
            private float m_LastWindowY;
            private float m_LastWindowWidth;
            private float m_LastWindowHeight;
            private float m_LastWindowScale;

            public override void Initialize(params object[] args)
            {
                m_DebuggerComponent = GameEntry.GetComponent<DebuggerComponent>();
                if (m_DebuggerComponent == null)
                {
                    Log.Fatal("Debugger component is invalid.");
                    return;
                }

                m_SettingComponent = GameEntry.GetComponent<SettingComponent>();
                if (m_SettingComponent == null)
                {
                    Log.Fatal("Setting component is invalid.");
                    return;
                }

                m_LastIconX = m_SettingComponent.GetFloat("Debugger.Icon.X", DefaultIconRect.x);
                m_LastIconY = m_SettingComponent.GetFloat("Debugger.Icon.Y", DefaultIconRect.y);
                m_LastWindowX = m_SettingComponent.GetFloat("Debugger.Window.X", DefaultWindowRect.x);
                m_LastWindowY = m_SettingComponent.GetFloat("Debugger.Window.Y", DefaultWindowRect.y);
                m_LastWindowWidth = m_SettingComponent.GetFloat("Debugger.Window.Width", DefaultWindowRect.width);
                m_LastWindowHeight = m_SettingComponent.GetFloat("Debugger.Window.Height", DefaultWindowRect.height);
                m_DebuggerComponent.WindowScale = m_LastWindowScale = m_SettingComponent.GetFloat("Debugger.Window.Scale", DefaultWindowScale);
                m_DebuggerComponent.IconRect = new Rect(m_LastIconX, m_LastIconY, DefaultIconRect.width, DefaultIconRect.height);
                m_DebuggerComponent.WindowRect = new Rect(m_LastWindowX, m_LastWindowY, m_LastWindowWidth, m_LastWindowHeight);
            }

            public override void OnUpdate(float elapseSeconds, float realElapseSeconds)
            {
                if (m_LastIconX != m_DebuggerComponent.IconRect.x)
                {
                    m_LastIconX = m_DebuggerComponent.IconRect.x;
                    m_SettingComponent.SetFloat("Debugger.Icon.X", m_DebuggerComponent.IconRect.x);
                }

                if (m_LastIconY != m_DebuggerComponent.IconRect.y)
                {
                    m_LastIconY = m_DebuggerComponent.IconRect.y;
                    m_SettingComponent.SetFloat("Debugger.Icon.Y", m_DebuggerComponent.IconRect.y);
                }

                if (m_LastWindowX != m_DebuggerComponent.WindowRect.x)
                {
                    m_LastWindowX = m_DebuggerComponent.WindowRect.x;
                    m_SettingComponent.SetFloat("Debugger.Window.X", m_DebuggerComponent.WindowRect.x);
                }

                if (m_LastWindowY != m_DebuggerComponent.WindowRect.y)
                {
                    m_LastWindowY = m_DebuggerComponent.WindowRect.y;
                    m_SettingComponent.SetFloat("Debugger.Window.Y", m_DebuggerComponent.WindowRect.y);
                }

                if (m_LastWindowWidth != m_DebuggerComponent.WindowRect.width)
                {
                    m_LastWindowWidth = m_DebuggerComponent.WindowRect.width;
                    m_SettingComponent.SetFloat("Debugger.Window.Width", m_DebuggerComponent.WindowRect.width);
                }

                if (m_LastWindowHeight != m_DebuggerComponent.WindowRect.height)
                {
                    m_LastWindowHeight = m_DebuggerComponent.WindowRect.height;
                    m_SettingComponent.SetFloat("Debugger.Window.Height", m_DebuggerComponent.WindowRect.height);
                }

                if (m_LastWindowScale != m_DebuggerComponent.WindowScale)
                {
                    m_LastWindowScale = m_DebuggerComponent.WindowScale;
                    m_SettingComponent.SetFloat("Debugger.Window.Scale", m_DebuggerComponent.WindowScale);
                }
            }

            protected override void OnDrawScrollableWindow()
            {
                GUILayout.Label("<b>Window Settings</b>");
                GUILayout.BeginVertical("box");
                {
                    GUILayout.BeginHorizontal();
                    {
                        GUILayout.Label("Position:", GUILayout.Width(60f));
                        GUILayout.Label("Drag window caption to move position.");
                    }
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    {
                        float width = m_DebuggerComponent.WindowRect.width;
                        GUILayout.Label("Width:", GUILayout.Width(60f));
                        if (GUILayout.RepeatButton("-", GUILayout.Width(30f)))
                        {
                            width--;
                        }
                        width = GUILayout.HorizontalSlider(width, 100f, Screen.width - 20f);
                        if (GUILayout.RepeatButton("+", GUILayout.Width(30f)))
                        {
                            width++;
                        }
                        width = Mathf.Clamp(width, 100f, Screen.width - 20f);
                        if (width != m_DebuggerComponent.WindowRect.width)
                        {
                            m_DebuggerComponent.WindowRect = new Rect(m_DebuggerComponent.WindowRect.x, m_DebuggerComponent.WindowRect.y, width, m_DebuggerComponent.WindowRect.height);
                        }
                    }
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    {
                        float height = m_DebuggerComponent.WindowRect.height;
                        GUILayout.Label("Height:", GUILayout.Width(60f));
                        if (GUILayout.RepeatButton("-", GUILayout.Width(30f)))
                        {
                            height--;
                        }
                        height = GUILayout.HorizontalSlider(height, 100f, Screen.height - 20f);
                        if (GUILayout.RepeatButton("+", GUILayout.Width(30f)))
                        {
                            height++;
                        }
                        height = Mathf.Clamp(height, 100f, Screen.height - 20f);
                        if (height != m_DebuggerComponent.WindowRect.height)
                        {
                            m_DebuggerComponent.WindowRect = new Rect(m_DebuggerComponent.WindowRect.x, m_DebuggerComponent.WindowRect.y, m_DebuggerComponent.WindowRect.width, height);
                        }
                    }
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    {
                        float scale = m_DebuggerComponent.WindowScale;
                        GUILayout.Label("Scale:", GUILayout.Width(60f));
                        if (GUILayout.RepeatButton("-", GUILayout.Width(30f)))
                        {
                            scale -= 0.01f;
                        }
                        scale = GUILayout.HorizontalSlider(scale, 0.5f, 4f);
                        if (GUILayout.RepeatButton("+", GUILayout.Width(30f)))
                        {
                            scale += 0.01f;
                        }
                        scale = Mathf.Clamp(scale, 0.5f, 4f);
                        if (scale != m_DebuggerComponent.WindowScale)
                        {
                            m_DebuggerComponent.WindowScale = scale;
                        }
                    }
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    {
                        if (GUILayout.Button("0.5x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 0.5f;
                        }
                        if (GUILayout.Button("1.0x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 1f;
                        }
                        if (GUILayout.Button("1.5x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 1.5f;
                        }
                        if (GUILayout.Button("2.0x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 2f;
                        }
                        if (GUILayout.Button("2.5x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 2.5f;
                        }
                        if (GUILayout.Button("3.0x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 3f;
                        }
                        if (GUILayout.Button("3.5x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 3.5f;
                        }
                        if (GUILayout.Button("4.0x", GUILayout.Height(60f)))
                        {
                            m_DebuggerComponent.WindowScale = 4f;
                        }
                    }
                    GUILayout.EndHorizontal();

                    if (GUILayout.Button("Reset Layout", GUILayout.Height(30f)))
                    {
                        m_DebuggerComponent.ResetLayout();
                    }
                }
                GUILayout.EndVertical();
            }
        }
    }
}
