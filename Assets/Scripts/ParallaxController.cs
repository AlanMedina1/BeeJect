using UnityEngine;

public class ParallaxController : MonoBehaviour

/*    [SerializeField] private float scrollSpeed = 0.1f;
    private Vector2 offset;
    private Material material;

    void Start()
    {
        // Obtiene el material del sprite (usa un shader que permita scroll, como Unlit/Texture)
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // Mueve la textura del material en el eje X
        offset = new Vector2(Time.time * scrollSpeed, 0);
        material.mainTextureOffset = offset;
    }*/
{
[SerializeField] private float scrollSpeed = 1f;
    [SerializeField] private Transform secondBackground; // el fondo duplicado
    private float spriteWidth;

    void Start()
    {
        // Calcula el ancho del sprite
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Mueve ambos fondos hacia la izquierda
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
        secondBackground.position += Vector3.left * scrollSpeed * Time.deltaTime;

        // Si el fondo principal salió completamente de la cámara, lo reposiciona al final del otro
        if (transform.position.x <= -spriteWidth)
        {
            transform.position = new Vector3(secondBackground.position.x + spriteWidth, transform.position.y, transform.position.z);
        }

        if (secondBackground.position.x <= -spriteWidth)
        {
            secondBackground.position = new Vector3(transform.position.x + spriteWidth, secondBackground.position.y, secondBackground.position.z);
        }
    }
}