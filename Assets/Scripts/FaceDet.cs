using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FaceDet : MonoBehaviour
{
    DiceRoll dice;
    [SerializeField] private float stopThreshold = 0.1f;

    private void Awake()
    {
        dice = FindObjectOfType<DiceRoll>();
    }

   private void OnTriggerStay(Collider other)
    {
        if (dice != null && dice.GetComponent<Rigidbody>() != null)
        {
            // Check if dice is stopped or almost stopped
            if (dice.GetComponent<Rigidbody>().velocity.magnitude < stopThreshold)
            {
                // Ensure the other collider's name can be parsed to an integer
                if (int.TryParse(other.name, out int faceNumber))
                {
                    dice.diceFaceNum = faceNumber;
                }
            }
        }
    }
}