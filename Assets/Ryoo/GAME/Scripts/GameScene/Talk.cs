using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
    //public Dialogue info;

    //public Animator anim;

    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.name == "G1_Black")
    //    {
    //        Debug.Log("collision");
    //        if (Input.GetKeyDown(KeyCode.Q))
    //        {
    //            Debug.Log("collision2");
    //            GetComponent<DialogueTrigger_GS>().Trigger();
    //        }
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
            transform.LookAt(other.transform);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                image.GetComponent<FadeOut>().fadeout();
                StartCoroutine(nextScene());

                Debug.Log("collision2");
                Invoke("nextScene", 0.5f);
            }
            
        }
    }

    IEnumerator nextScene()
    {

        yield return new WaitForSeconds(1f);
        Debug.Log("씬 이동 (돌다리 대화 1)");
        SceneManager.LoadScene("TalkScene1");
    }

    //public void Trigger()
    //{
    //    anim.SetBool("isClick", true);


    //    var system = FindObjectOfType<DialogueSystem_GS>();
    //    system.Begin(info);
}

