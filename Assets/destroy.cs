using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 5.0f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
