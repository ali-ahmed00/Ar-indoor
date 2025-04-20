using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

public class DestinationButton : MonoBehaviour
{
    public Transform destination; // Assign room location in Inspector
    public NavigationPath navigationPath;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SetDestination);
    }

    void SetDestination()
    {
        Vector3[] path = navigationPath.CalculatePath(Camera.main.transform);
        // Send path to the arrow/line system
    }
}