using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �}�E�X���N���b�N���ꂽ�ꍇ
        if (Input.GetMouseButtonDown(0))
        {
            // Animator�R���|�[�l���g���擾���A"jumpTrigger"��true�ɂ���
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
    }
}
