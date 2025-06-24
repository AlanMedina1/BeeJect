using UnityEngine;

public class NivelController : MonoBehaviour
{
    float velocidad = 20f;

    void Start()
    {
        Destroy(gameObject, 8f); // Destruye el objeto después de 7 segundos
    }
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
