using System;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[Serializable]
	public class AtomEventHandlerInt : AtomEventHandler<int, AtomEventInt, UnityEvent<int>> { }
}