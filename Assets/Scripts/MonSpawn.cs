using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] mons;
    [SerializeField] private GameObject player;

    [SerializeField] private int monSelect = -1;

    private void Start()
    {
        monSelect = 0;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && monSelect >= 1)
        {
            monSelect--;
            Debug.Log(monSelect);
        }
        if (Input.GetKeyDown(KeyCode.E) && monSelect < mons.Length - 1)
        {
            monSelect++;
            Debug.Log(monSelect);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            SpawnMonGround();
            Destroy(gameObject);
        }
    }

    private void SpawnMonGround()
    {
        if (monSelect > -1 && monSelect <= mons.Length - 1)
        {
            Instantiate(mons[monSelect], gameObject.transform.position + new Vector3(0.0f, 3.0f, 0.0f), 
                player.transform.rotation);
        }
        else
        {
            Debug.Log("There is no Mon to spawn");
        }
    }

    public void SpawnMonPlayer()
    {
        if (monSelect > -1 && monSelect < mons.Length - 1)
        {
            Instantiate(mons[monSelect], player.transform.position + new Vector3(0.0f, 0.0f, 3.0f),
                player.transform.rotation);
        }
        else
        {
            Debug.Log("There is no Mon to spawn");
        }
    }
}
