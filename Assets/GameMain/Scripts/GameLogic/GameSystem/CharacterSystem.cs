
using System.Collections.Generic;

namespace GameTowerDefense
{
	/// <summary>
	/// ��ɫ����ϵͳ
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
			��ɾ�Ĳ��Ӧ����
		 */
    }
}

