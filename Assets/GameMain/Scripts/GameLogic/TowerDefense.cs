using GameFramework.Event;
using System;
using UnityGameFramework.Runtime;
namespace GameTowerDefense
{
    /// <summary>
    /// 中介者类  整个游戏各个系统
    /// </summary>
    public class TowerDefense : GameLogicBase
    {
        public override void Init()
        {
            GameEntry.Event.Subscribe(ShowEntitySuccessEventArgs.EventId, OnShowEntitySuccess);

            GameEntry.Entity.ShowEnemyEntity(60001);
        }

      

       

        public override void Update()
        {
            
        }



        public override void OnDestroy()
        {
            GameEntry.Event.Subscribe(ShowEntitySuccessEventArgs.EventId, OnShowEntitySuccess);
        }

        private void OnShowEntitySuccess(object sender, GameEventArgs e)
        {
           
        }
    }
}

