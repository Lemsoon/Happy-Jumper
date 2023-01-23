using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    public int _secondNum = 0;
    private GameObject _originalCloud;
    public SpawnPlatform _spawnPlatform;
    void Start()
    {
        Vector3 _randomSpawn = new Vector3(Random.Range(-100, 100), Random.Range(50, 75), 0);
        _originalCloud = GameObject.Find("Cloud_Default");
        Instantiate(_originalCloud, _randomSpawn, Quaternion.identity).name = "New Cloud";
    }

    public void SpawnCloud()
    {
        _secondNum++;
        if(_secondNum%2 == 0){
            int RandomNumber = Random.Range(0, 4);
            if(RandomNumber == 1)
            {
                GameObject _genCloud = GameObject.Find("New Cloud");
                Vector3 _randomSpawn = new Vector3(_spawnPlatform._temp.transform.position.x + Random.Range(-100, 100), _spawnPlatform._temp.transform.position.y + Random.Range(50, 75), 0);
                Instantiate(_genCloud, _randomSpawn, Quaternion.identity).name = "New Cloud";
                _genCloud.name = "Old Cloud";
                _genCloud = null;
            }

        }
    }

    public void FirstClouds()
    {
        _secondNum++;
        if(_secondNum%2 == 0){
            int RandomNumber = Random.Range(0, 3);
            if(RandomNumber == 1)
            {
                GameObject _originalCloud = GameObject.Find("Cloud_Default");
                Vector3 _randomSpawn = new Vector3(_spawnPlatform._cloudPlat.transform.position.x + Random.Range(-100, 100), _spawnPlatform._cloudPlat.transform.position.y + Random.Range(50, 75), 0);
                Instantiate(_originalCloud, _randomSpawn, Quaternion.identity).name = "New Cloud";
                GameObject _InstantiatedCloud = GameObject.Find("New Cloud");
            }
        }
    }
}