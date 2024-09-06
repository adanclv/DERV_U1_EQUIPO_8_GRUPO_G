using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class P2_Chats : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo
    {
        public string name;
        public string chat;
        public Sprite imagen;
    }
    public List<Dialogo> chats;

    [SerializeField] TextMeshProUGUI mensaje;
    [SerializeField] Image foto;
    [SerializeField] TextMeshProUGUI nombre;

    int contador;
    void mostrarDialogo()
    {
        mensaje.text = chats[contador].chat;
        nombre.text = chats[contador].name;
        foto.sprite = chats[contador].imagen;
    }
    
    void Start()
    {
        contador = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contador++;
            contador %= chats.Count;
            Debug.Log(contador);
            mostrarDialogo();
        }
    }
}