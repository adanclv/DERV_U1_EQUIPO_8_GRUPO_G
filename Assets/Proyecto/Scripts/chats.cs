using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class chats : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo
    {
        public string name;
        public string chat;
        public Sprite imagen;
    }
    public List<Dialogo> chat;

    [SerializeField] TextMeshProUGUI mensaje;
    [SerializeField] Image foto;
    [SerializeField] TextMeshProUGUI nombre;

    int contador;
    void showDialogo()
    {
        mensaje.text = chat[contador].chat;
        nombre.text = chat[contador].name;
        foto.sprite = chat[contador].imagen;
    }

    void Start()
    {
        contador = 0;
        showDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contador++;
            contador %= chat.Count;
            showDialogo();
        }
    }
}
