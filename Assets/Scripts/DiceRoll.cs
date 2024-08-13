using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DiceRoll : MonoBehaviour
{
    private Rigidbody body;

    [SerializeField] private float maxRandomForceValue = 3000f;
    [SerializeField] private float startRollingForce = 1000f;

    private float forceX, forceY, forceZ;

    public int diceFaceNum;

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        if (body != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RollDice();
            }
        }
    }

    // Method to roll the dice
    public void RollDice()
    {
        body.isKinematic = false;

        forceX = Random.Range(0, maxRandomForceValue);
        forceY = Random.Range(0, maxRandomForceValue);
        forceZ = Random.Range(0, maxRandomForceValue);

        body.AddForce(Vector3.up * startRollingForce);
        body.AddTorque(forceX, forceY, forceZ);
    }

    private void Initialize()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = true;
        transform.rotation = Random.rotation; // Random rotation
    }
}
