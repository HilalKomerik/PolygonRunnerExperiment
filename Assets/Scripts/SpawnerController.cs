using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstacles;
    [SerializeField] private float _minX, _maxX;
    [SerializeField] private float _time;
    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }
    IEnumerator Spawn() // Ne kadar s�re �al��mas� gerekkti�ini biz karar vericez.
    {
        while (true)
        {
            yield return new WaitForSeconds(_time); // �u i�lemi yap bekle sonra tekrar yap 
            int _randoIndex = Random.Range(0, _obstacles.Length);
            GameObject _newObstacles = Instantiate(_obstacles[_randoIndex]); // Instantiate �o�altmaya yarark
            if (_randoIndex == 1)
            {
                _newObstacles.transform.position = new Vector3(
                    0f,
                    transform.position.y,
                    transform.position.z);
            }
            else
            {
                _newObstacles.transform.position = new Vector3(
                    Random.Range(_minX, _maxX),
                    transform.position.y,
                    transform.position.z);
            }
            

        }
    }
}
