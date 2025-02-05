using UnityEngine;

/// <summary>
/// The abstract class for objects which are capable of spawning other objects.
/// </summary>
public abstract class Spawner : MonoBehaviour
{
    /// <summary>
    /// The spawn info for the spawner.
    /// </summary>
    public abstract SpawnInfo SpawnInfo { get; }


    /// <summary>
    /// Spawns the object at the requested position.
    /// </summary>
    /// <remarks>
    /// <b>Notes for implementers:</b><br/>
    /// This method should be prepared to handle any position argument. <br/>
    /// It is not always intended that the object spawn in the exact position given, so if the given position is invalid, spawn in some location nearby.
    /// </remarks>
    public abstract void Spawn(Vector3 position);
}