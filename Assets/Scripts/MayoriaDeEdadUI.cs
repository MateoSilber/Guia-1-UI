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
        txt_Resultado.text = "Acá va el resultado";
    }
}
