
using System.Collections.Generic;

namespace GameTowerDefense
{
	/// <summary>
	/// 角色管理系统
	/// </summary>
	public class CharacterSystem:TowerDefenseGameSystem
	{
		private List<Attacker> m_Attackers;

		private List<Turret> m_Turret;



        public override void Init(TowerDefense towerDefense)
        {
            base.Init(towerDefense);

			m_Attackers = new List<Attacker>();
			m_Turret = new List<Turret>();

		}

		/*
			增删改查对应方法
		 */
    }
}

