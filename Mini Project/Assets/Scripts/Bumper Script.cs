using System.Xml.Serialization;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    private float sizeDownCD;
    private Vector3 ogSize;
    private void OnCollisionEnter(Collision collision)
    {
        if (transform.localScale == ogSize)
        {
            transform.localScale = transform.localScale + new Vector3(1f,1,1f);
            sizeDownCD = 0;
        }
    }

    private void Start()
    {
        ogSize = transform.localScale;
    }
    void Update()
    {
        sizeDownCD += Time.deltaTime;
        if (sizeDownCD > 0.2)
        {
            transform.localScale = ogSize;
        }
    }
}
