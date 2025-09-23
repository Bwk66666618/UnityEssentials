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
	float Randoomx = Random.Range(0.2f,5f);
	float Randoomy = Random.Range(0.2f,5f);
	float Randoomz = Random.Range(0.2f,5f);
        sunlightSpeed =+ sunlightSpeed + 0.01f;
	transform.Rotate(sunlightSpeed*Randoomx, sunlightSpeed*Randoomy, sunlightSpeed*Randoomz);
    }
}
