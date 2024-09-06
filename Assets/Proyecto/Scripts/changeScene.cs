using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    private void Update()
    {
        int actual_escena = SceneManager.GetActiveScene().buildIndex;

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (actual_escena == 0)
            {
                cambioDeEscena(1);
            }
            else if (actual_escena == 1)
            {
                cambioDeEscena(2);
            }
            else
            {
                cambioDeEscena(0);
            }
        }
    }

    public void cambioDeEscena(int index)
    {
        SceneManager.LoadScene(index);
    }
}

