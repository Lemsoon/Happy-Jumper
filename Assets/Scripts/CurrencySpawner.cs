using UnityEngine;
using UnityEngine.UI;
 

public class CurrencySpawner : MonoBehaviour
{
    private int _rand, _currencyAmount;
    private Text _currencyDisplay;
    private GameObject _coin;
    void Start() => _coin = GameObject.Find("coin");

    public void AttemptCurrencySpawn()
    {
        _rand = Random.Range(0,101);

        if(_rand <= 5)
        {
            Vector3 _randomPos = new Vector3(Random.Range(-60, 61), 190, 0);
            Instantiate(_coin, _randomPos, Quaternion.identity).GetComponent<Rigidbody2D>().simulated = true;
        }
    }
}