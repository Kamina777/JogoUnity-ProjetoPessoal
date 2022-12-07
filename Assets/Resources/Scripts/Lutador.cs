using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Lutador : MonoBehaviour
{
    [SerializeField] private StatsScriptableObject stats;
    [SerializeField] private TiposDeArma tiposDeArma;
    [SerializeField] private GameObject filhoArmas;
    [SerializeField] private string nome;
    [SerializeField] private string classe;
    [SerializeField] private int level = 1;
    [SerializeField] private int hp;
    [SerializeField] private int forca;
    [SerializeField] private int agilidade;
    [SerializeField] private int inteligencia;
    [SerializeField] private int dano;
    [SerializeField] private EscolhaDaArma escolhaDaArma;
    [SerializeField] private Transform alvo;

    void Start()
    {
        filhoArmas = transform.GetChild(0).gameObject;
        escolhaDaArma = filhoArmas.GetComponent<EscolhaDaArma>();
        StatsAtuais();
        CalculaDano();
    }
    private void Update()
    {
        CalculaDano();
    }
    private int CalculaDano()
    {
        if (escolhaDaArma.fisicoOuMagico())
        {
            return dano = escolhaDaArma.ForcaArmaEscolhida() + this.forca;
        }
        else
        {
            return dano = escolhaDaArma.InteligenciaArmaEscolhida() + this.inteligencia;
        }
    }
    private void StatsAtuais()
    {
        this.hp = stats.HpMax + ((level - 1) * stats.HpMaxGanho);
        this.forca = stats.Forca + (stats.ForcaGanho * (level - 1));
        this.agilidade = stats.Agilidade + (stats.AgilidadeGanho * (level - 1));
        this.inteligencia = stats.Inteligencia + (stats.InteligenciaGanho * (level - 1));
    }

    private void LvlUp()
    {
        this.level += 1;
        StatsAtuais();
        CalculaDano();
    }
    public void setAlvo(Transform alvo){
        this.alvo = alvo;
    }

    public Transform retornaReferencia(){
        return this.transform;
    }
}
