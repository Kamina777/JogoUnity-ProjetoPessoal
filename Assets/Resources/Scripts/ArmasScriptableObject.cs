using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armas", menuName = "TiposArmas")]
public class ArmasScriptableObject : ScriptableObject
{
	[SerializeField] private string nomeArma;
	public string NomeArma
	{
		get { return nomeArma; }
		set { nomeArma = value; }
	}

    [SerializeField] private int forcaArma;
	public int ForcaArma

	{
		get { return forcaArma; }
		set { forcaArma = value; }
	}

    [SerializeField] private int inteligenciaArma;
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
}
