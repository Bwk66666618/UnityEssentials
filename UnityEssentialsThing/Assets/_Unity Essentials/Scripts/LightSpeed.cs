using UnityEngine;

public class LightSpeed : MonoBehaviour
{
	public float sunlightSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sunlightSpeed =+ sunlightSpeed + 0.01f;
	transform.Rotate(sunlightSpeed, sunlightSpeed, sunlightSpeed);
    }
}
