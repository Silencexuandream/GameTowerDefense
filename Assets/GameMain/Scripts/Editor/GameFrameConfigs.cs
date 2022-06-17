
using GameFramework;
using System.IO;
using UnityEngine;
using UnityGameFramework.Editor.ResourceTools;


namespace GameTowerDefense
{
	public static class GameFrameConfigs 
	{
		  

		[ResourceEditorConfigPath]
		public static string ResourcesEnitorConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/Configs/ResourceEditor.xml"));


		[ResourceCollectionConfigPath]
		public static string ResourcesCollectionConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/Configs/ResourceCollection.xml"));

		[ResourceBuilderConfigPath]
		public static string ResourceBuilderConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/Configs/ResourceBuilder.xml"));

	}
}

