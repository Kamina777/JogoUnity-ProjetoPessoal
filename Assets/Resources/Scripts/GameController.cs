using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject jogador;
    [SerializeField] GameObject inimigo;
    [SerializeField] GameObject canvasDaLuta;
    [SerializeField] Slider hpJogador;
    [SerializeField] Slider hpInimigo;
    [SerializeField] Mapa mapa;

    public void Start()
    {
        mapa = GameObject.FindGameObjectWithTag("Mapa").GetComponent<Mapa>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            mapa.PlayerSpawn();
            mapa.EnemySpawn();
            IniciaABatalha();
        }
    }
    public void IniciaABatalha()
    {
        canvasDaLuta.gameObject.SetActive(true);
        jogador = GameObject.FindGameObjectWithTag("Player");
        inimigo = GameObject.FindGameObjectWithTag("Enemy");
        hpJogador = canvasDaLuta.transform.Find("HpJogador").GetComponent<Slider>();
        hpInimigo = canvasDaLuta.transform.Find("HpInimigo").GetComponent<Slider>();
        
    }
}
