using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTowerDefense
{
    public interface ICharacterFactory
    {

        T Create<T>()where T :ICharacter;
        
    }

}