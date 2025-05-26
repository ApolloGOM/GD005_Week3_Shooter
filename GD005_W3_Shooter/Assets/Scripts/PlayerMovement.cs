using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    float horizontalInput, verticalInput;
    private int xRange = 15;
    //private int zRange = 20;
    public GameObject projectile;
    public int score;
    public TMP_Text scoreText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
      // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;

        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

       if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }



        scoreText.text = "Score: " + score;

        //Shooting mechanic
        //A way to register input
        //We need a logic to spawn an object

        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(projectile, transform.position, transform.rotation);
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
