using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    RaycastHit objectOnHitLine;
    [SerializeField, Range (1,100)] float gunDamage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out objectOnHitLine))               ////если на линии поражения 
        {
            if(objectOnHitLine.transform.tag=="Enemy")                                             ////  Если тег enemy
            {
                if(Input.GetMouseButtonDown(0))                                                    //// Если нажата кнопка
                {
                    objectOnHitLine.transform.GetComponent<EnemyController>().TakeSerum(gunDamage);             //// наносим урон врагу 
                    /// if enemy healh < 0 
                    int scores = PlayerPrefs.GetInt("Scores")  +  1;
                    PlayerPrefs.SetInt("Scores", scores);
                }
            }
        }
    }
}
