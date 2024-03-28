using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody rigidbody2;
    public int pointValue;
    public ParticleSystem particle;

    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rigidbody2 = GetComponent<Rigidbody>();
        rigidbody2.AddForce(Vector2.up * Random.Range(12, 16), ForceMode.Impulse);
        rigidbody2.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        transform.position = new Vector2(Random.Range(-4, 4), -2);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) )
        {
            
           
            
            if(IsMouseOverObject() && gameManager.isGameActive)
            {
                Destroy(gameObject);
                Instantiate(particle, transform.position, particle.transform.rotation);
                gameManager.UpdateScore(pointValue);
            }
        }
    }

    private bool IsMouseOverObject()
    {
        // Cast a ray from the mouse position into the scene
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if the ray intersects with any collider
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the collider hit by the ray is the same as this GameObject's collider
            if (hit.collider.gameObject == gameObject)
            {
                return true;
            }
        }

        return false;
    }
   
  
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (gameObject.CompareTag("Good")&& gameManager.live >0)
        {
            gameManager.lives.text = "Lives : " + gameManager.live;

            gameManager.live -= 1;

        }
        if (gameManager.live == 0)
        {
            gameManager.lives.text = "Lives : " + gameManager.live;
            gameManager.GameOver();
        }
    }
}
