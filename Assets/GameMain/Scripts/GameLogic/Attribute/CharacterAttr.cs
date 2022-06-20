using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTowerDefense
{
    public abstract class CharacterAttr : ICharacterAttr
    {
        private int m_Hp;

        private int m_MaxHp;

        private float m_MoveSpeed;

        public int Hp
        {
            get { return m_Hp; }

            set { m_Hp = value; }
        }
        public int MaxHp
        {
            get { return m_MaxHp; }

            set { m_MaxHp = value; }
        }
        public float MoveSpeed
        {
            get { return m_MoveSpeed; }

            set { m_MoveSpeed = value; }
        }
    }
}
