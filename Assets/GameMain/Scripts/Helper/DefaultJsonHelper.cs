using System;
using UnityGameFramework.Runtime;
using Newtonsoft.Json;

/// <summary>
/// 默认Json辅助器。
/// Unity中Newtonsoft在处理嵌套结构比LitJson准确；比SimpleJSON更易用。
/// </summary>
public class DefaultJsonHelper : Utility.Json.IJsonHelper
{
    public string ToJson(object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public T ToObject<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }

    public object ToObject(Type objectType, string json)
    {
        return JsonConvert.DeserializeObject(json, objectType);
    }
}