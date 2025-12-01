using TMPro;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed;
    [SerializeField] private TextMeshProUGUI value;
    [SerializeField] private TextMeshProUGUI value2;
    public float respawnTimer;



    private void Start()
    {
        value.text = tag;
        value2.text = tag;
    }
    void FixedUpdate()
    {
        transform.Rotate(rotationSpeed);
    }
}
