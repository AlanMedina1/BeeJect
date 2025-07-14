using UnityEngine;

public class PlayerController: MonoBehaviour
    
{
    public float fuerzaVuelo = 10f;
    private Rigidbody2D rb;

    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vuelo();
            anim.SetBool("isFliying", true); // Cambia el trigger del animador al volar
            Debug.Log("Se ha pulsado el botón izquierdo del ratón, ESTA VOLANDO");

        }
        else
        {
            anim.SetBool("isFliying", false); // Cambia el trigger del animador al estar en reposo
            Debug.Log("No se ha pulsado el botón izquierdo del ratón");
        }
    }

    void Vuelo()
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(new Vector2(0,fuerzaVuelo), ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Punto"))
        {
            // Aquí puedes agregar la lógica que deseas ejecutar al colisionar con el "punto""
            Debug.Log("Punto obtenido");
            GameManager.Instance.SumarPunto(); // Llama al método para sumar puntos
        }       
    }
    
}
