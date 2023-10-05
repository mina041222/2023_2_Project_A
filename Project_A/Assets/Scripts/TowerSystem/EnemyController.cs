using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;         //�� �̵��ӵ�

    private MonsterPath thePath;        //�н�������
    private int currentpoint;           //�н� ��ġ Ŀ����
    private bool reachedEnd;            //���� �Ϸ� �˻� bool�� 
    // Start is called before the first frame update
    void Start()
    {
        if (thePath == null)            //�����Ҷ� Path�� ������
        {
            thePath = FindObjectofType<MonsterPath>();      //Scene ���� ã�´�.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedEnd == false )       //���� �Ϸᰡ �ƴҰ��
        {
            transform.LookAt(thePath.points[currentpoint]);    //���� ��ġ Ŀ������ ���ؼ� ����.

            transform.position = Vector3.MoveTowards(transform.position, thePath.points[currentPoint].position, moveSpeed * Time.deltaTime);

            //���� �н� ����Ʈ ��ġ�� �Ÿ��� ����ؼ� 
        }    
        
    }
}
