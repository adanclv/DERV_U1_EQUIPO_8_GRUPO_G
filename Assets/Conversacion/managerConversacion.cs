using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class managerConversacion : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo {
        public string name;
        public string texto;
        public Sprite imagen;
    }
    public List<Dialogo> charla;

    [SerializeField] TextMeshProUGUI mensaje;
    [SerializeField] Image foto ;
    [SerializeField] TextMeshProUGUI nombre;

    int contador;
    void mostrarDialogo()
    {
        mensaje.text = charla[contador].texto;
        nombre.text = charla[contador].name;
        foto.sprite = charla[contador].imagen;
    }
    // Start is called before the first frame update
    void Start()
    {
            contador = 0;
            mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) { 
            contador++;
            contador %= charla.Count;
            Debug.Log(contador);
            mostrarDialogo();
        }
    }
}
