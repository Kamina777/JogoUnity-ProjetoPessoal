using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class EscolhaDaArma : MonoBehaviour
{
    [SerializeField] private int quantidadeArmas;
    [SerializeField] private int escolhaDaArma;
    [SerializeField] private List<GameObject> tiposDeArma;

    void Start()
    {
    }

    public void ListandoArmasChild()
    {
        quantidadeArmas = transform.childCount;
        for (int i = 0; i < quantidadeArmas; i++) // nunca quero que o soco entra na lista, por isso começa i = 1
        {
            tiposDeArma.Add(transform.GetChild(i).gameObject);
        }
    }

    public void IniciarLuta()
    {
        ListandoArmasChild();
        EscolhendoArma();
    }

    public int ForcaArmaEscolhida()
    {
        return tiposDeArma[escolhaDaArma].GetComponent<TiposDeArma>().ForcaArma;
    }
    public int InteligenciaArmaEscolhida()
    {
        return tiposDeArma[escolhaDaArma].GetComponent<TiposDeArma>().InteligenciaArma;
    }

    public bool fisicoOuMagico()
    {
        return tiposDeArma[escolhaDaArma].GetComponent<TiposDeArma>().EhFisico;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TrocandoArma();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ListandoArmasChild();
            Debug.Log("listando as armas em child");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            IniciarLuta();
        }
    }
    private void EscolhendoArma()
    {
        escolhaDaArma = Random.Range(0, tiposDeArma.Count); // COMEÇA NO 1 PRA NÃO TIRAR O SOCO
        tiposDeArma[escolhaDaArma].gameObject.SetActive(true);
    }
    public void TrocandoArma()
    {
        if (escolhaDaArma != 0)
        {
            Destroy(tiposDeArma[escolhaDaArma].gameObject);
            tiposDeArma.Remove(tiposDeArma[escolhaDaArma]);
        }
        else
        {
            tiposDeArma[0].gameObject.SetActive(false);
        }
        EscolhendoArma();
    }
}
