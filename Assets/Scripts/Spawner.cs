using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public List<GameObject> clones;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1; i <= 50; i++)
        {
            GameObject other = Instantiate(obj);
            other.transform.position = new Vector3(0, i, 0);
            clones.Add(other);
        }
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
