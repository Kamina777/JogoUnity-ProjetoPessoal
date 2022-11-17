using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TiposDeArma : MonoBehaviour
{
    [SerializeField] private ArmasScriptableObject armas;
    [SerializeField] private string nomeArma;

    [SerializeField] private int forcaArma;
    public int ForcaArma
    {
        get { return forcaArma; }
        set { forcaArma = value; }
    }

    [SerializeField]private int inteligenciaArma;
    public int InteligenciaArma
    {
        get { return inteligenciaArma; }
        set { inteligenciaArma = value; }
    }

    [SerializeField] private bool ehFisico;
    public bool EhFisico
    {
        get { return ehFisico; }
        set { ehFisico = true; }
    }

    private void Start()
    {
        this.nomeArma = armas.NomeArma;
        this.forcaArma = armas.ForcaArma;
        this.inteligenciaArma = armas.InteligenciaArma;
        this.ehFisico = armas.EhFisico;
        //PEGAR A REFERENCIA DO SCRIPT EscolhaDaArma
    }
    
}
