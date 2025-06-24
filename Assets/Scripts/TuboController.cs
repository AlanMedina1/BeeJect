using UnityEngine;

public class TuboController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Aquí puedes agregar la lógica que deseas ejecutar al colisionar con el jugador
            Debug.Log("Colisión con el jugador detectada.");
            Destroy(collision.gameObject); // Destruye el jugador al colisionar con el tubo
        }
    }
}
