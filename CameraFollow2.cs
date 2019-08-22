using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    private Transform playerTransform;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        print(Screen.width);

		if (Screen.width == 1200)
		{
			offset = 600;
		}
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.x += offset;
        transform.position = temp;
    }
}
