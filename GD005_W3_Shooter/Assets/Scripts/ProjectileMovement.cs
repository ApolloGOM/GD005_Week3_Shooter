using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 15f;
    private float delayTime = 3.0f;
    public float projectile;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroyObject", delayTime);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }


}
    
    
