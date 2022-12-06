using System;
using UnityEngine;

namespace DataTypes
{
    [CreateAssetMenu(fileName = "New Float",menuName = "Data Types/Float")]
    public class FloatVar : ScriptableObject
    {
        public float value;
    }

    [Serializable]
    public class FloatRef
    {
        public FloatVar var;
        public bool canSet;

        public float Value
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