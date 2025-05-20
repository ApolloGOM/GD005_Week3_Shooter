using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    float horizontalInput, verticalInput;
    private int xRange = 15;
    private int zRange = 20;
    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        
        //Shooting mechanic
        //A way to register input
        //We need a logic to spawn an object

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
           projectile = Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
        #region
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if (transform.position.z > 15f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15f);
        }
        
        if (transform.position.z < -2f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2f);
        }
        #endregion
    }
}
