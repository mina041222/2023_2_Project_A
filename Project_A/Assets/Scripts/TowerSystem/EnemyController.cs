using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;         //적 이동속도

    private MonsterPath thePath;        //패스정보값
    private int currentpoint;           //패스 위치 커서값
    private bool reachedEnd;            //도달 완료 검사 bool값 
    // Start is called before the first frame update
    void Start()
    {
        if (thePath == null)            //시작할때 Path가 없으면
        {
            thePath = FindObjectofType<MonsterPath>();      //Scene 에서 찾는다.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedEnd == false )       //도달 완료가 아닐경우
        {
            transform.LookAt(thePath.points[currentpoint]);    //지금 위치 커서값을 향해서 본다.

            transform.position = Vector3.MoveTowards(transform.position, thePath.points[currentPoint].position, moveSpeed * Time.deltaTime);

            //나의 패스 포인트 위치의 거리를 계산해서 
        }    
        
    }
}
