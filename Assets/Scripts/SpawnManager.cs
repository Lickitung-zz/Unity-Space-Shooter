using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn game object every 5 seconds
    //Create a coroutine of type IEnumerator -- Yield Events
    //while loop
    IEnumerator SpawnRoutine()
    {
        Enemy enemy = transform.GetComponent<Enemy>();
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-18.0f, 12.5f), 12.48f, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(5);
        }
    }
}
