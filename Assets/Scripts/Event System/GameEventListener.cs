using System;
using UnityEngine;
using UnityEngine.Events;

namespace Event_System
{
        public class GameEventListener : MonoBehaviour
        {
                public GameEvent gameEvent;
                public UnityEvent response;

                private void OnEnable()
                {
                        gameEvent.RegisterGameEvent(this);
                }

                private void OnDisable()
                {
                        gameEvent.UnregisterGameEvent(this);
                }

                public void OnEventRaised()
                {
                        response.Invoke();
                }
        }
}