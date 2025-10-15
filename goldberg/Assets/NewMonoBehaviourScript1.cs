using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public Material defaultMaterial;
    public Material touchedMaterial;

    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null && defaultMaterial != null)
        {
            meshRenderer.material = defaultMaterial; 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (meshRenderer != null && touchedMaterial != null)
            {
                meshRenderer.material = touchedMaterial;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (meshRenderer != null && defaultMaterial != null)
            {
                meshRenderer.material = defaultMaterial;
            }
        }
    }
}
