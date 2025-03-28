﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 版本资源列表更新失败回调函数。
    /// </summary>
    /// <param name="downloadUri">版本资源列表更新地址。</param>
    /// <param name="errorMessage">错误信息。</param>
    public delegate void UpdateVersionListFailureCallback(string downloadUri, string errorMessage);
}
