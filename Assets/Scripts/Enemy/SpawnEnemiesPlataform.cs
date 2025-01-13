using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPlataform : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject currentEnemy;

    public List<Transform> points = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {


    }
    
    public void Spawn()
    {
        //aqui o checa se o inimigo foi destruido
        if (currentEnemy == null)
        {
            //aqui executa se for destruido

            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, points.Count);

        GameObject e = Instantiate(enemyPrefab, points[pos].position, points[pos].rotation);
        currentEnemy = e;


        
    }

}
