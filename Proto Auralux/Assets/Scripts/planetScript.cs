using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class planetScript : MonoBehaviour
{

    [SerializeField]
    private float _timeSpawn;

    [SerializeField]
    private float _energyPerSecond;

    [SerializeField]
    private float _level;

    public int planetState = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTroop();
        }
    }

    public void SpawnTroop()
    {
        Debug.Log("SPAWN");
        var troop = Resources.Load<GameObject>("Troop");
        Instantiate(troop, this.transform.position, Quaternion.identity);
       
    }

    public float GetEnergy()
    {
        return _energyPerSecond;
    }
}
