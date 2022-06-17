
using GameFramework.Fsm;
using GameFramework.Resource;
using UnityGameFramework.Runtime;

namespace GameTowerDefense
{
    public class PorcedureSplash : ProcedureBase
    {


        protected override void OnUpdate(IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);


            //TODO


            if (GameEntry.Base.EditorResourceMode)
            {
                ChangeState<ProcedurePreload>(procedureOwner);
            }
            else if (GameEntry.Resource.ResourceMode == ResourceMode.Package)
            {
                ChangeState<ProcedureInitResources>(procedureOwner);
            }
            else
            {
                ChangeState<ProcedureCheckVersion>(procedureOwner);
            }
        }
    }

}
