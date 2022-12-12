using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LuckyBlock : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _hit;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        var player = other.collider.GetComponent<PlayerMovement>();
        if (player && other.contacts[0].normal.y > 0)
        {
            GetComponent<LootBag>().InstantiateLoot(transform.position);
            _hit?.Invoke();
        }
    }

    
}
