using UnityEngine.SceneManagement;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public SpawnPlatform spawnPlatform;
    public Rigidbody2D _rb;
    public int deathVelocity, JumpStrenth;
    public float moveSpeed;
    void Start()
     {       
        _rb = this.GetComponent<Rigidbody2D>();
     }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "DefaultPlatform" || col.gameObject.tag == "JumpedOn" && _rb.velocity.y < 0.1f)
            _rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y + JumpStrenth);

        if(col.gameObject.tag == "DefaultPlatform")
        {
            spawnPlatform.GeneratePlatform();
        }
    }
    void Update()=>Movement();
    void FixedUpdate()
    {
        if(_rb.velocity.y > 0)
            GetComponent<BoxCollider2D>().enabled = false;
        else
            GetComponent<BoxCollider2D>().enabled = true;
        if(transform.position.y < -150)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void Movement()
    {
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, transform.position.z);
    }
}
