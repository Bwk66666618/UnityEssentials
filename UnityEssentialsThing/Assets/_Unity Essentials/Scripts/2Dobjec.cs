using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
	private float Static;
	public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	float Randoom = Random.Range(-0.5f, 0.5f);
	rotationSpeed =+ rotationSpeed + Randoom * 2;
        transform.Rotate(0, 0, rotationSpeed);
    }

}
