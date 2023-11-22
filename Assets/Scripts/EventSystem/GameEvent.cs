using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
	[SerializeField, Tooltip("This event should cause an action")] private bool activeEvent;
	[SerializeField, Tooltip("This event should notify of an event, that happened")] private bool passiveEvent;
	[SerializeField, TextArea, Tooltip("Optional")] private string dataDescription;

	public List<GameEventListener> listeners = new List<GameEventListener>();

	public void Raise(Component sender, List<object> data)
	{
		for(int i = 0; i < listeners.Count; i++)
		{
			listeners[i].OnEventRaised(sender, data);
		}
	}

	public void RegisterListener(GameEventListener listener) 
	{
		if (!listeners.Contains(listener))
			listeners.Add(listener);
	}

	public void UnregisterListener(GameEventListener listener)
	{
		if (listeners.Contains(listener))
			listeners.Remove(listener);
	}
}
