using System.Collections.Generic;
using UnityEngine;

namespace Event_System
{
    [CreateAssetMenu(fileName = "New Game Event",menuName = "Systems/Game Event")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> _gameEventListeners = new List<GameEventListener>();

        public void Raise()
        {
            for (var i = _gameEventListeners.Count - 1; i >= 0; i--)
            {
                _gameEventListeners[i].OnEventRaised();
            }
        }

        public void RegisterGameEvent(GameEventListener e)
        {
            if (!_gameEventListeners.Contains(e))
                _gameEventListeners.Add(e);
        }
        public void UnregisterGameEvent(GameEventListener e)
        {
            if (_gameEventListeners.Contains(e))
                _gameEventListeners.Remove(e);
        }
    }
}
