using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : MonoBehaviour
{
    [SerializeField] private Mon[] mons;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform battlePos;

    public Vector3 GetBattlePos() { return battlePos.position; }
     
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        SearchForPlayer();
    }

    private void SearchForPlayer()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 100.0f, LayerMask.GetMask("Player")))
        {
            if(hit.collider.gameObject.tag == "Player")
            {
                Debug.Log("Battle Start!");
                BattleSystem.StartBattle(this, hit.collider.gameObject);
            }
        }
    }

}
