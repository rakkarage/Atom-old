﻿using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	public abstract class AtomReference<T, H, E, UE> : ScriptableObject
		where H : AtomEventHandler<T, E, UE>
		where E : AtomEvent<T>
		where UE: UnityEvent<T>
	{
		[SerializeField]
		private T _value;
		public T Value
		{
			get { return _value; }
			set
			{
				_value = value;
				Changed.Raise(_value);
			}
		}
		public E Changed;
	}
}
