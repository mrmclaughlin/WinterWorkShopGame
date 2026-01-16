using UnityEngine;

public class PassthroughTrigger : MonoBehaviour
{
    [SerializeField] private OVRPassthroughLayer passthrough;
    [SerializeField] private string rigTag = "XR Rig";

    private void Awake()
    {
        if (passthrough != null)
            passthrough.enabled = false; // start OFF
    }

    private void OnTriggerEnter(Collider other)
    {
        if (passthrough != null && other.CompareTag(rigTag))
            passthrough.enabled = true; // turn ON
    }

    private void OnTriggerExit(Collider other)
    {
        if (passthrough != null && other.CompareTag(rigTag))
            passthrough.enabled = false; // turn OFF
    }
}
