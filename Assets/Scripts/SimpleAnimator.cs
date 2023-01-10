using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimator : MonoBehaviour
{
    private float _phase = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _phase = Random.Range(0f, Mathf.PI * 2);
    }

    // Update is called once per frame
    void Update()
    {
        _phase += Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, Mathf.Sin(_phase) * 0.05f);
    }
}
