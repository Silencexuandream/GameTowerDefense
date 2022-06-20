using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameTowerDefense
{
    public interface ICharacterAttr
    {

        int Hp { get; set; }

        int MaxHp { get; set; }

        float MoveSpeed { get; set; }


    }
}
