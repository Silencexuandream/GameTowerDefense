using GameFramework.Fsm;
using System;
using UnityGameFramework.Runtime;

namespace GameTowerDefense
{
    public class ProcedureMain : ProcedureBase
    {
        private const float GameOverDelayedSeconds = 2f;
       
        private float m_DelaySeconds = 0;

        private TowerDefense m_TowerDefense;
        protected override void OnEnter(IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            m_DelaySeconds = 0;

            //这里进行游戏逻辑编写
            m_TowerDefense = new TowerDefense();


            m_TowerDefense.Init();


        }


        protected override void OnUpdate(IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            m_TowerDefense.Update();


        }

        protected override void OnLeave(IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner, bool isShutdown)
        {

            m_TowerDefense.OnDestroy();
            base.OnLeave(procedureOwner, isShutdown);
        }

    }


}