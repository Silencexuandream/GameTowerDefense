
namespace GameTowerDefense
{
    public abstract class TowerDefenseGameSystem : IGameSystem<TowerDefense>
    {
        private TowerDefense m_TowerDefense;
        public TowerDefense GameLogic => m_TowerDefense;


      
        public virtual void Init(TowerDefense towerDefense)
        {
          
        }

        public virtual void OnDestroy()
        {
           
        }

        public virtual void Update()
        {
            
        }
    }
}

