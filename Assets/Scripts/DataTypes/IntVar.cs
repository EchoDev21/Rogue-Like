using System;
using UnityEngine;

namespace DataTypes
{
        [CreateAssetMenu(fileName = "New Int", menuName = "Data Types/Int")]
        public class IntVar : ScriptableObject
        {
                public int value;
        }

        [Serializable]
        public class IntRef
        {
                public IntVar var;
                public bool canSet;

                public int Value
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