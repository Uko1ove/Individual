using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleController : MonoBehaviour
{
    [SerializeField] GameObject circle;
    public bool isPlayersOne;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayersOne == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(41, 221, 221);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(208, 20, 222);
        }
    }
}
