using GameFramework.DataTable;
using System;
using UnityGameFramework.Runtime;
namespace GameTowerDefense
{
    public static class EntityExtension 
    {
        
        public static void ShowEnemyEntity(this EntityComponent entityComponent, int entityId)
        {
            IDataTable<DREnemy>drEntmies = GameEntry.DataTable.GetDataTable<DREnemy>();

            DREnemy enemyData =  drEntmies.GetDataRow(entityId);

            if(!GameEntry.Entity.HasEntityGroup(enemyData.EntityGroup))
            {
                GameEntry.Entity.AddEntityGroup(enemyData.EntityGroup,60,5,60,0);
            }

            Type EntityLogic = Type.GetType($"GameTowerDefense.{enemyData.EntityLogic}");

            GameEntry.Entity.ShowEntity(enemyData.Id,EntityLogic, AssetUtility.GetEntityEnemy(enemyData.AssetsName),enemyData.EntityGroup, enemyData);
        }

    }

}
