using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Atributos", menuName = "NovoLutador")]
public class StatsScriptableObject : ScriptableObject
{

    [SerializeField] private int hpMax;
    public int HpMax
    {
        get { return hpMax; }
        set { hpMax = value; }
    }

    [SerializeField] private int hpMaxGanho;
    public int HpMaxGanho
    {
        get { return hpMaxGanho; }
        set { hpMaxGanho = value; }
    }

    [SerializeField] private int forca;
    public int Forca
    {
        get { return forca; }
        set { forca = value; }
    }

    [SerializeField] private int forcaGanho;
    public int ForcaGanho
    {
        get { return forcaGanho; }
        set { forcaGanho = value; }
    }

    [SerializeField] private int agilidade;
    public int Agilidade
    {
        get { return agilidade; }
        set { agilidade = value; }
    }

    [SerializeField] private int agilidadeGanho;
    public int AgilidadeGanho
    {
        get { return agilidadeGanho; }
        set { agilidadeGanho = value; }
    }

    [SerializeField] private int inteligencia;
    public int Inteligencia
    {
        get { return inteligencia; }
        set { inteligencia = value; }
    }

    [SerializeField] private int ingeligenciaGanho;
    public int InteligenciaGanho
    {
        get { return ingeligenciaGanho; }
        set { ingeligenciaGanho = value; }
    }

}
