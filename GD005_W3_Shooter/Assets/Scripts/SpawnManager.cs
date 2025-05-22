using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public float xRange, zRange;
    public animalInfo[] animalInformation;
    //public string[] names;
    public float spawnInterval, startDelay;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log(names[2]);
        InvokeRepeating("spawnAnimals", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            CancelInvoke("spawnAnimals");
        }


        



        //[System.Serializable]
       // public struct animalInfo

    {

       // public GameObject animalPrefab;
       // public string animalName;
        //public bool isHostile;

    }
    }
    void spawnAnimals()
    {
        int animalindex = Random.Range(0, animals.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), 0, Random.Range(zRange, -zRange));
        Instantiate(animals[animalindex], spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0));
    }
}
