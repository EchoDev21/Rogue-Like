using System;
using UnityEngine;

namespace DataTypes
{
    [CreateAssetMenu(fileName = "New Vector3",menuName = "Data Types/Vector3")]
    public class Vector3Var : ScriptableObject
    {
        public Vector3 value;
    }

    [Serializable]
    public class Vector3Ref
    {
        public Vector3Var var;
        public bool canSet;

        public Vector3 Value
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