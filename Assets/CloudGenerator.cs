using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    private GameObject _originalCloud;
    private Vector3 _randomSpawn;
    void Start()
    {
        _randomSpawn = new Vector3(Random.Range(-100, 100), Random.Range(50, 75), 0);
        _originalCloud = GameObject.Find("Cloud_Default");
        Instantiate(_originalCloud, _randomSpawn, Quaternion.identity);
    }
}