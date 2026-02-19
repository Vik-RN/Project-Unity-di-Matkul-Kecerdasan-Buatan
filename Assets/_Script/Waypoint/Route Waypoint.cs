using UnityEngine;

[CreateAssetMenu(fileName = "RouteWaypoint", menuName = "Scriptable Objects/RouteWaypoint")]
public class RouteWaypoint : ScriptableObject
{
    public Vector3 pointA;
    public Vector3 pointB;
}
