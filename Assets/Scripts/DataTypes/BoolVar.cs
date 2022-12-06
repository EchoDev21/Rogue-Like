using System;
using UnityEngine;

namespace DataTypes
{
    [CreateAssetMenu(fileName = "New Bool",menuName = "Data Types/Bool")]
    public class BoolVar : ScriptableObject
    {
        public bool value;
    }

    [Serializable]
    public class BoolRef
    {
        public BoolVar var;
        public bool canSet;

        public bool Value
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
