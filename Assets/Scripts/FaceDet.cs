using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FaceDet : MonoBehaviour
{
    private DiceRoll dice;

    private void Awake()
    {
        dice = FindObjectOfType<DiceRoll>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (dice != null)
        {
            if (dice.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                // Ensure that the other collider's name can be parsed to an integer
                if (int.TryParse(other.name, out int faceNumber))
                {
                    dice.diceFaceNum = faceNumber;
                }
            }
        }
    }
}