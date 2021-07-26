using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]

public class Sweet : MonoBehaviour
{
    public GameObject prefab;

    [Tooltip("x-rotation")] [Range(-5, 5)] public int x = 0;
    [Tooltip("y-rotation")] [Range(-5, 5)] public int y = 0;
    [Tooltip("z-rotation")] [Range(-5, 5)] public int z = 0;
    [Range(0, 15)] public float speed = 0;

    [SerializeField] private bool isPlayEditor = false;
    private Vector3 prefabPosition;
    private int count = 0;
    private List<GameObject> copies;
    void Awake()
    {
        prefabPosition = transform.position;
    }

    void Update()
    {
        if (isPlayEditor)
        {
            transform.rotation *= Quaternion.Euler(x*Time.deltaTime*speed,y*Time.deltaTime*speed,z*Time.deltaTime*speed);
        }
    }
    public void Copy()
    {
        prefabPosition = new Vector3(prefabPosition.x - 3f, prefabPosition.y, prefabPosition.z);
        GameObject copy = Instantiate(prefab, prefabPosition, Quaternion.identity);
        copies.Add(copy);
    }
    public void DeleteOriginal()
    {
       
        GameObject.Destroy(prefab);
    }
    public void DeleteCopies()
    {
        foreach(GameObject gameObject in copies)
        {
            Destroy(gameObject);
        }
    }
}
