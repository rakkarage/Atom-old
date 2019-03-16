using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Vector3Int")]
	public class AtomVector3Int : AtomReference<Vector3Int, AtomEventHandlerVector3Int, AtomEventVector3Int, UnityEventVector3Int> { }
}
