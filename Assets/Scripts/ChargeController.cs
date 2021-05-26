using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChargeController : MonoBehaviour
{
    [SerializeField] int maxCharge;
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] bool isNeutral;
    [SerializeField] GameObject circleInner;
    private int currentCharge;
    private bool isPlayersOne;
    private bool isSelected;


    void Start()
    {

    }

    void Update()
    {
        currentCharge = int.Parse(textMeshPro.text);        
    }

    private void FixedUpdate()
    {
        if (currentCharge < maxCharge && isNeutral == false)
        {
            currentCharge += 1;
            textMeshPro.text = currentCharge.ToString();
        }
        else if (currentCharge > maxCharge && isNeutral == false)
        {
            currentCharge -= 1;
            textMeshPro.text = currentCharge.ToString();
        }
        else
        {
            return;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<ChargeController>().isPlayersOne == true)
        {
            currentCharge += 1;
        }
        else
        {
            currentCharge -= 1;
            if (currentCharge > 0)
            {
                circleInner.GetComponent<SpriteRenderer>().color = new Color(41, 221, 221);
            }
            else
            {
                currentCharge = 1;
                isPlayersOne = false;
                circleInner.GetComponent<SpriteRenderer>().color = new Color(208, 20, 222);
            }
        }
    }

}
