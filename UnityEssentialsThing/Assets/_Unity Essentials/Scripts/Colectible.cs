using UnityEngine;

public class Colectible : MonoBehaviour
{
	private float Static;
	public float rotationSpeed;
	public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	float Static = Random.Range(-0.001f, 0.005f);
    }

    // Update is called once per frame
    void Update()
    {
	float Randoom = Random.Range(-0.01f, 0.01f);
	rotationSpeed =+ rotationSpeed + Randoom + Static;
        transform.Rotate(0, rotationSpeed, 0);
    }
	private void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		Instantiate(onCollectEffect, transform.position, transform.rotation);
	}
}
