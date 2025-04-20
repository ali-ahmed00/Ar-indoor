using UnityEngine;

using UnityEngine;
using UnityEngine.AI;

public class NavigationPath : MonoBehaviour
{
    public Transform target; // Destination (set in Inspector)
    private NavMeshPath path;
    public LineRenderer lineRenderer;

    void Start()
    {
        path = new NavMeshPath();
    }

    public Vector3[] CalculatePath(Transform startPoint)
    {
        NavMesh.CalculatePath(startPoint.position, target.position, NavMesh.AllAreas, path);
        return path.corners;
    }
    public void UpdatePathVisualization(Vector3[] pathPoints)
    {
        lineRenderer.positionCount = pathPoints.Length;
        lineRenderer.SetPositions(pathPoints);
    }
}