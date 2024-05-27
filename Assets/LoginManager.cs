using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Cuando el usuario presione el boton aceptar debe escribirse un mensaje en consola
//Si el texto del InputField coincide con una contraseña predefinada por ustedes
//EScribir "Access granted", si no escribir "Access denied"
public class LoginManager : MonoBehaviour
{
    public Text mensaje;
    public InputField texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonpresionado()
    {
        if (texto.text == "Peruga")
        {
            Debug.Log("Access granted");
        }

        else
        {
            Debug.Log("Access denied");
        }
    }
}
