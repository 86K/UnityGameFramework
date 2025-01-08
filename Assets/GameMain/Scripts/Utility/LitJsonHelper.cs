//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using LitJson;
using System;
using System.Reflection;
using UnityGameFramework.Runtime;

namespace StarForce
{
    /// <summary>
    /// LitJSON 函数集辅助器。
    /// </summary>
    internal class LitJsonHelper : Utility.Json.IJsonHelper
    {
        /// <summary>
        /// 将对象序列化为 JSON 字符串。
        /// </summary>
        /// <param name="obj">要序列化的对象。</param>
        /// <returns>序列化后的 JSON 字符串。</returns>
        public string ToJson(object obj)
        {
            return JsonMapper.ToJson(obj);
        }

        /// <summary>
        /// 将 JSON 字符串反序列化为对象。
        /// </summary>
        /// <typeparam name="T">对象类型。</typeparam>
        /// <param name="json">要反序列化的 JSON 字符串。</param>
        /// <returns>反序列化后的对象。</returns>
        public T ToObject<T>(string json)
        {
            return JsonMapper.ToObject<T>(json);
        }

        /// <summary>
        /// 将 JSON 字符串反序列化为对象。
        /// 未测试。
        /// 用途：动态类型反序列化（NameSpace.ClassName），更灵活的API。
        /// </summary>
        /// <param name="objectType">对象类型。</param>
        /// <param name="json">要反序列化的 JSON 字符串。</param>
        /// <returns>反序列化后的对象。</returns>
        public object ToObject(Type objectType, string json)
        {
            // 获取泛型方法 ToObject<T>
            var method = GetType().GetMethod("ToObject", BindingFlags.Public | BindingFlags.Instance);
            if (method == null)
            {
                throw new NotSupportedException("ToObject(Type objectType, string json)");
            }

            // 创建泛型方法 ToObject<T> 的实例
            var genericMethod = method.MakeGenericMethod(objectType);

            // 调用泛型方法并返回结果
            return genericMethod.Invoke(this, new object[] { json });
        }
    }
}
