using System.Collections.Generic;
using UnityEngine;

namespace Runtime_Sets
{
        public abstract class RuntimeSet<T> : ScriptableObject
        {
                public List<T> runtimeSet = new List<T>();

                public void InitializeSet()
                {
                        runtimeSet.Clear();
                }

                public abstract T FindItemInSet(T item);
        }
}