using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    [SerializeField] private List<GameObject> armasPrefab;
    [SerializeField] private GameObject playerParent;
    [SerializeField] private GameObject EscolhaDaArma;
    [SerializeField] private List<GameObject> enemyPrefab;
    [SerializeField] private List<GameObject> playerPrefab;
    [SerializeField] private Transform enemySpawn;
    [SerializeField] private Transform playerSpawn;
    [SerializeField] private int escolhaDoPlayer = 0;


    void Start()
    {
        armasPrefab = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs/Armas"));
        playerPrefab = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs/Lutadores"));
        //playerParent = GameObject.FindGameObjectWithTag("Player");
        enemyPrefab = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs/Inimigos"));
    }

    public void instantiatedDaArma()
    {
        if (armasPrefab != null)
        {
            int randomPrefab = Random.Range(0, armasPrefab.Count - 1); // fazer um if pra n�o ter arma repetida
            Instantiate(armasPrefab[randomPrefab], playerParent.transform.GetChild(0).GetComponent<Transform>());
            armasPrefab.Remove(armasPrefab[randomPrefab]);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerParent = GameObject.FindGameObjectWithTag("Player");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            instantiatedDaArma();
        }
    }

    public void SpawnDeLutadores()
    {
        int randomPrefab = Random.Range(0, enemyPrefab.Count - 1); // fazer um if pra n�o ter arma repetida
        var inimigo = Instantiate(enemyPrefab[randomPrefab], enemySpawn);
        var jogador = Instantiate(playerPrefab[escolhaDoPlayer], playerSpawn);
        inimigo.GetComponent<Lutador>().setAlvo(jogador.GetComponent<Lutador>().retornaReferencia());
        jogador.GetComponent<Lutador>().setAlvo(inimigo.GetComponent<Lutador>().retornaReferencia());

    }
}
