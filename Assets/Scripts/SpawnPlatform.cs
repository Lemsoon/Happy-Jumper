using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    [SerializeField]public GameObject _defaultPlatform, _player;
    void Start()
    {
        Instantiate(_defaultPlatform, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _defaultPlatform.transform.position.y + 25, 0), Quaternion.identity).name = "New Platform";
        for(int i = 0; i < 10; i++)
        {
            GameObject _temp = GameObject.Find("New Platform");
           _temp.name = "Platformed";
            Instantiate(_temp, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _temp.transform.position.y + 25, 0), Quaternion.identity).name = "New Platform";
        }
    }

    public void GeneratePlatform()
    {
        GameObject _temp = GameObject.Find("New Platform");
        _temp.name = "Platformed";
        Instantiate(_temp, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _temp.transform.position.y + 25f, 0), Quaternion.identity).name = "New Platform";
    }


    void Update()
    {
        
    }
    
}