using TMPro;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed;
    [SerializeField] private TextMeshProUGUI value;
    [SerializeField] private TextMeshProUGUI value2;
    public float respawnTimer;


    // sets each of the TMPtext components to be the same as the prefabs tag
    private void Start()
    {
        value.text = tag;
        value2.text = tag;
    }
    
    // constantly rotates the coins for visual effect
    void FixedUpdate()
    {
        transform.Rotate(rotationSpeed);
    }
}
