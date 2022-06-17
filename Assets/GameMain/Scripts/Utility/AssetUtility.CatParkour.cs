

using GameFramework;

namespace GameTowerDefense
{
    public static partial class AssetUtility
    {
        public static string GetCatParkourEntityAsset(string assetName)
        {
            return Utility.Text.Format("Assets/GameMain/Entities/CatParkour/{0}.prefab", assetName);
        }

    }

}
