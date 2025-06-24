using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager Instance;

    public int puntos = 0;
    public TMP_Text puntosText;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void SumarPunto()
    {
        puntos += 1;
        ActualizarPuntosUI();
    }

    private void ActualizarPuntosUI()
    {
        puntosText.text = puntos.ToString();
    }
}
