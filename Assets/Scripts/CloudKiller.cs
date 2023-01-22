using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudKiller : MonoBehaviour
{
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -150 && this.gameObject.name != "Cloud_Default")
            Destroy(this.gameObject);
        if(transform.position.y < -150 && this.gameObject.name == "Cloud_Default")
            _rb.simulated = false;
    }
}
