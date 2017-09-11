using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardSpawner : MonoBehaviour {


    public GameObject[] cards;
    public Sprite[] zone_middle; //卡牌中间区域JQK
    public Sprite[] zone_middle_below10; //卡牌中间区域小于10
    public Sprite[] angle;//卡牌角
    public string[] points = {"3","4","5","6","7","8","9","10","J","Q","K","A","2" };
    public int[] color;
    // Use this for initialization
    void Start()
    {
        SpawnNext(33);
    }

    // 生成一个随机方块
    void SpawnNext(int card_id)
    {
        // int i = Random.Range(0, cards.Length);
        int points_ = card_id / 4;
        int suit = card_id % 4;
        GameObject ins = Instantiate(cards[0], transform.position, Quaternion.identity) as GameObject; //实例化一张卡牌
        //Debug.Log("Start");
        SpriteRenderer[] sr = ins.GetComponentsInChildren<SpriteRenderer>();   
        for(int i = 0; i < sr.Length; i++)     //卡牌图片各部分更新
        {
            //debug.log("name:" + sr[i].name);
            //debug.log("tag:" + sr[i].tag);
            if(sr[i].name == "King")    //更新卡牌中间区域
            {
                if(points_>=8 && points_ <= 10)   //JQK时
                {
                    sr[i].sprite = zone_middle[points_-8];
                }
                else
                {
                    sr[i].sprite = zone_middle_below10[suit];
                }
                           
            }
            if (sr[i].name == "club_s" || sr[i].name == "club_s_below")    //更新卡牌角的花色
            {
              
                sr[i].sprite = angle[suit];
            }
       
        }
      
        TextMesh[] text = ins.GetComponentsInChildren<TextMesh>();
        for(int i = 0; i < text.Length; i++)
        {
            text[i].text = points[points_];
            if(card_id %2 == 0)
            {
                text[i].color = Color.black;
            }
            else
            {
                text[i].color = Color.red;
            }
        }   
          
    }
}