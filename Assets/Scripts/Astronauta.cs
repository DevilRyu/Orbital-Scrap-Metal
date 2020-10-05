using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astronauta : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX, dirY, moveSpeed;
    GameObject healthbar;

    [SerializeField]
    private Text coinCounter;

    private int collidedCoinValue;

    private int moneyAmount;

    void Awake() 
    {
        healthbar = GameObject.FindGameObjectWithTag("HealthBar");
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        moneyAmount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        dirY = Input.GetAxisRaw("Vertical") * moveSpeed;
        coinCounter.text = "Coins: " + moneyAmount;
        if (healthbar.GetComponent<Healthbar>().health<=0)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>()!= null) {

            collidedCoinValue = collision.gameObject.GetComponent<Coin>().coinValue;
            moneyAmount += collidedCoinValue;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Asteroid")
        {
            healthbar.GetComponent<Healthbar>().TakeDamage(25); ;
        }
        

    }

}