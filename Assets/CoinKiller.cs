using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name=="coin" && transform.position.y < -200)
            GetComponent<Rigidbody2D>().simulated = false;
        if(this.gameObject.name!="coin" && transform.position.y < -200)
            Destroy(this.gameObject);

    }
}
