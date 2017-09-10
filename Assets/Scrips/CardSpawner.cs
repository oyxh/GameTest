using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardSpawner : MonoBehaviour {


    public GameObject[] cards;
    // Use this for initialization
    void Start()
    {
        SpawnNext();
    }

    // 生成一个随机方块
    void SpawnNext()
    {
       // int i = Random.Range(0, cards.Length);
        GameObject ins = Instantiate(cards[0], transform.position, Quaternion.identity) as GameObject;
    }
}