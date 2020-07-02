using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monkeyController : MonoBehaviour
{
    public float monkeySpeed;
    Vector3 position;
    public uiManager ui;
    private int count;
    public Text countText;
    private int coinn;
    public Text coinnText;


    void Awake()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        //ui = GetComponent<uiManager>();
        count = 0;
        coinn = 0;
        SetCountText();
        SetCoinnText();
        position = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * monkeySpeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -2.5f, 2.5f);

        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kite")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Banana"))
        {
            Destroy(other.gameObject);
            count = count + 1;

            SetCountText();
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinn = coinn + 1;

            SetCoinnText();
        }
    }


    void SetCountText()
    {
        countText.text = "X " + count.ToString();
    }

    void SetCoinnText()
    {
        coinnText.text = "X " + coinn.ToString();

    }
}


