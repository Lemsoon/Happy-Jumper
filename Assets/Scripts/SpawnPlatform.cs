using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject _temp, _cloudPlat;
    [SerializeField]public GameObject _defaultPlatform, _player;
    public CloudGenerator _cloudGen;
    void Start()
    {
        Instantiate(_defaultPlatform, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _defaultPlatform.transform.position.y + 25f, 0), Quaternion.identity).name = "New Platform";
        for(int i = 0; i < 10; i++)
        {
            GameObject _tempi = GameObject.Find("New Platform");
            _cloudPlat = _tempi;

            _cloudGen.FirstClouds();
            _tempi.name = "Platformed";
            Instantiate(_tempi, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _tempi.transform.position.y + 25f, 0), Quaternion.identity).name = "New Platform";
        }
    }

    public void GeneratePlatform()
    {
        _temp = GameObject.Find("New Platform");
        _temp.name = "Platformed";
        Instantiate(_temp, new Vector3(_defaultPlatform.transform.position.x + Random.Range(-50f, 50f), _temp.transform.position.y + 25f, 0), Quaternion.identity).name = "New Platform";
    }


    void Update()
    {
        
    }
    
}