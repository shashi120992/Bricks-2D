using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    public class BrickPoint : MonoBehaviour
    {
        public Brick brick;
        
        public void print()
        {
            Debug.Log("Print Score");
        }
    }
}