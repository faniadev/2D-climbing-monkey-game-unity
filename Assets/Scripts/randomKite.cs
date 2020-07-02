using UnityEngine;
using System.Collections;

public class randomKite : MonoBehaviour
{
    public GameObject kite;
    public float maxPos = 1.8f;
    public float delayTimer = 1f; 
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;

    }
    void Update()
    {

            timer -= Time.deltaTime;
            if( timer <= 0)
        {
            Vector3 kitePos = new Vector3(Random.Range(-1.8f, 1.8f), transform.position.y, transform.position.z);

            Instantiate(kite, kitePos, transform.rotation);
            timer = delayTimer;
        }

        }
    }

