//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityGameFramework.Runtime;

namespace StarForce
{
    public static class AssetUtility
    {
        private static string AssetRootFolder = "Assets/GameMain";
        
        public static string GetConfigAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Configs/{{0}}.{{1}}", assetName, fromBytes ? "bytes" : "txt");
        }

        public static string GetDataTableAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format($"{AssetRootFolder}/DataTables/{{0}}.{{1}}", assetName, fromBytes ? "bytes" : "txt");
        }

        public static string GetDictionaryAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Localization/{{0}}/Dictionaries/{{1}}.{{2}}", GameEntry.Localization.Language, assetName, fromBytes ? "bytes" : "xml");
        }

        public static string GetFontAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Fonts/{{0}}.ttf", assetName);
        }

        public static string GetSceneAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Scenes/{{0}}.unity", assetName);
        }

        public static string GetMusicAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Music/{{0}}.mp3", assetName);
        }

        public static string GetSoundAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Sounds/{{0}}.wav", assetName);
        }

        public static string GetEntityAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/Entities/{{0}}.prefab", assetName);
        }

        public static string GetUIFormAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/UI/UIForms/{{0}}.prefab", assetName);
        }

        public static string GetUISoundAsset(string assetName)
        {
            return Utility.Text.Format($"{AssetRootFolder}/UI/UISounds/{{0}}.wav", assetName);
        }
    }
}
