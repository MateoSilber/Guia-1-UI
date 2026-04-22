using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SumaDeNumerosUI : MonoBehaviour
{
    public TMP_InputField input_N1;
    public TMP_InputField input_N2;
    public TextMeshProUGUI txt_Resultado;
    // Start is called before the first frame update
    void Start()
    { 
    }
    // Update is called once per frame
    void Update()
    {    
    }
    public void AddToNumbers (){
        int numeroUno = int.Parse(input_N1.text);
        int numeroDos = int.Parse(input_N2.text);
        int resultado;
        resultado = numeroUno + numeroDos;
        txt_Resultado.text = resultado.ToString();
        if(numeroUno < 0){
        txt_Resultado.text = "Error, el primer numero es negativo";
        }
        if(numeroDos < 0){
        txt_Resultado.text = "Error, el segundo numero es negativo";
        }
    }
}
