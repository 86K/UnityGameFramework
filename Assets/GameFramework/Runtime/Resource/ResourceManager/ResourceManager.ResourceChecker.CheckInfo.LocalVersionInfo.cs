﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System.Runtime.InteropServices;

namespace UnityGameFramework.Runtime
{
    internal sealed partial class ResourceManager : GameFrameworkModule, IResourceManager
    {
        private sealed partial class ResourceChecker
        {
            private sealed partial class CheckInfo
            {
                /// <summary>
                /// 本地资源状态信息。
                /// </summary>
                [StructLayout(LayoutKind.Auto)]
                private struct LocalVersionInfo
                {
                    private readonly bool m_Exist;
                    private readonly string m_FileSystemName;
                    private readonly LoadType m_LoadType;
                    private readonly int m_Length;
                    private readonly int m_HashCode;

                    public LocalVersionInfo(string fileSystemName, LoadType loadType, int length, int hashCode)
                    {
                        m_Exist = true;
                        m_FileSystemName = fileSystemName;
                        m_LoadType = loadType;
                        m_Length = length;
                        m_HashCode = hashCode;
                    }

                    public bool Exist => m_Exist;

                    public bool UseFileSystem => !string.IsNullOrEmpty(m_FileSystemName);

                    public string FileSystemName => m_FileSystemName;

                    public LoadType LoadType => m_LoadType;

                    public int Length => m_Length;

                    public int HashCode => m_HashCode;
                }
            }
        }
    }
}
