//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using System.Xml;
using UnityGameFramework.Runtime;

namespace StarForce
{
    /// <summary>
    /// XML 格式的本地化辅助器。
    /// </summary>
    public class XmlLocalizationHelper : DefaultLocalizationHelper
    {
        /// <summary>
        /// 解析字典。
        /// </summary>
        /// <param name="localizationManager"></param>
        /// <param name="dictionaryString">要解析的字典字符串。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns>是否解析字典成功。</returns>
        public override bool ParseData(ILocalizationManager localizationManager, string dictionaryString, object userData)
        {
            try
            {
                string currentLanguage = GameEntry.Localization.Language.ToString();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(dictionaryString);
                XmlNode xmlRoot = xmlDocument.SelectSingleNode("Dictionaries");
                if (xmlRoot != null)
                {
                    XmlNodeList xmlNodeDictionaryList = xmlRoot.ChildNodes;
                    for (int i = 0; i < xmlNodeDictionaryList.Count; i++)
                    {
                        XmlNode xmlNodeDictionary = xmlNodeDictionaryList.Item(i);
                        if (xmlNodeDictionary != null && xmlNodeDictionary.Name != "Dictionary")
                        {
                            continue;
                        }

                        if (xmlNodeDictionary != null && xmlNodeDictionary.Attributes != null)
                        {
                            string language = xmlNodeDictionary.Attributes.GetNamedItem("Language").Value;
                            if (language != currentLanguage)
                            {
                                continue;
                            }
                        }

                        if (xmlNodeDictionary != null)
                        {
                            XmlNodeList xmlNodeStringList = xmlNodeDictionary.ChildNodes;
                            for (int j = 0; j < xmlNodeStringList.Count; j++)
                            {
                                XmlNode xmlNodeString = xmlNodeStringList.Item(j);
                                if (xmlNodeString != null && xmlNodeString.Name != "String")
                                {
                                    continue;
                                }

                                if (xmlNodeString != null && xmlNodeString.Attributes != null)
                                {
                                    string key = xmlNodeString.Attributes.GetNamedItem("Key").Value;
                                    string value = xmlNodeString.Attributes.GetNamedItem("Value").Value;
                                    if (!localizationManager.AddRawString(key, value))
                                    {
                                        Log.Warning("Can not add raw string with key '{0}' which may be invalid or duplicate.", key);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                Log.Warning("Can not parse dictionary data with exception '{0}'.", exception.ToString());
                return false;
            }
        }
    }
}
