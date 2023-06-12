using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;



public class FindPlayer : MonoBehaviour
{
 public GameObject target;
 NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       agent.destination = target.transform.position;   
    }

     void OnCollisionEnter(Collision collisionInfo)
    {
      Debug.Log(collisionInfo.collider.tag );
        if (collisionInfo.collider.tag == "Player") 
        {
           SceneManager.LoadScene(0);
        }
    }
}
