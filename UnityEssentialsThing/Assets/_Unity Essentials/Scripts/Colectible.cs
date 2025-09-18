using UnityEngine;

public class Colectible : MonoBehaviour
{
	public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	
    }

    // Update is called once per frame
    void Update()
    {
	rotationSpeed =+ rotationSpeed + 0.001f;
        transform.Rotate(0, rotationSpeed, 0);
    }
}
