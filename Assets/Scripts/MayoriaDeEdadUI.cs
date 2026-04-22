using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MayoriaDeEdadUI : MonoBehaviour
{
    public TMP_InputField input_IngresoEdad;
    public TextMeshProUGUI txt_Resultado;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckLegalAge(){
        int userAge = int.Parse(input_IngresoEdad.text);
        if(userAge < 18){
        txt_Resultado.text = "No es mayor";
        }else {
        txt_Resultado.text = "Es mayor";
        }
    }
}
