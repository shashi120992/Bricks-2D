using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName ="New Brick", menuName ="Brick")]
    public class Bricks : ScriptableObject
    {
        public string Name;
        public string color;
        public int point;
    }
}