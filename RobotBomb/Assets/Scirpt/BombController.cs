using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject hp = GameObject.Find("HpController");

        if (collision.gameObject.tag == "ROBOT")
        {
            hp.GetComponent<HpController>().HpControl();
        }
        Destroy(gameObject);
    }

}
