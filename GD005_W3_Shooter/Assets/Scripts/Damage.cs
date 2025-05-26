using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 1;
    private Health playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tara")
        {
            if (playerHealth == null)
            {
                playerHealth = collision.gameObject.GetComponent<Health>();
            }
            playerHealth.TakeDamage(damage);
        }
    }
}
