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
        // マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            // Animatorコンポーネントを取得し、"jumpTrigger"をtrueにする
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
    }
}
