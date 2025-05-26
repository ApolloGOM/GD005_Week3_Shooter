using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public int score;
    private float delayTime = 5.0f;
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroyObject", delayTime);
    }

    void DestroyObject ()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")

        GameObject.Find("Tara").GetComponent<PlayerMovement>().score++;
        Debug.Log(GameObject.Find("Tara").GetComponent<PlayerMovement>().score);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

