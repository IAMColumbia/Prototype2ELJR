using UnityEngine;

public class SpawnManger3 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(obstaclePrefab, spawnpos,obstaclePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
