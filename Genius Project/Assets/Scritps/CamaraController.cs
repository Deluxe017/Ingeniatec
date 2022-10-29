using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player;
    public Transform room;
    

    public static CamaraController instance;

    [Range(-5,5)]
    public float minModsX,maxModsX,minModsY,maxModsY;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        var minPostY = room.GetComponent<BoxCollider2D>().bounds.min.y + minModsY;
        var maxPostY = room.GetComponent<BoxCollider2D>().bounds.max.y + maxModsY;
        var minPostX = room.GetComponent<BoxCollider2D>().bounds.min.x + minModsX;
        var maxPostX = room.GetComponent<BoxCollider2D>().bounds.max.x + maxModsX;

        Vector3 clampedPos = new Vector3(Mathf.Clamp(player.position.x, minPostX, maxPostX),
        Mathf.Clamp(player.position.y, minPostY, maxPostY), Mathf.Clamp(player.position.z, -10, -10));
       
        
        transform.position = new Vector3(clampedPos.x,clampedPos.y,clampedPos.z);
    }
}
