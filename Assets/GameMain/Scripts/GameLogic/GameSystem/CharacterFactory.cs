using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace GameTowerDefense
{
    public class CharacterFactory : ICharacterFactory
    {
        public T Create<T>() where T : ICharacter
        {
           T t = Activator.CreateInstance<T>();

            return t;
        }
    }

}
