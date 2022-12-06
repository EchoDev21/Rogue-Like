using System;
using UnityEngine;

namespace DataTypes
{
    [CreateAssetMenu(fileName = "New Vector2",menuName = "Data Types/Vector2")]
    public class Vector2Var : ScriptableObject
    {
        public Vector2 value;
    }

    [Serializable]
    public class Vector2Ref
    {
        public Vector2Var var;
        public bool canSet;

        public Vector2 Value
        {
            get => var.value;
            set
            {
                if (canSet)
                    var.value = value;
            }
        }
    }
}