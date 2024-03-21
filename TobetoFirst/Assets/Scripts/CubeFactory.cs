using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory : MonoBehaviour
{

    [SerializeField] private GameObject _cubePreFab;
    [SerializeField] private int xAxis;
    [SerializeField] private int zAxis;
    [SerializeField] private float padding;
    private Vector3 initPos;
    
    
    private void Start()
    {
        initPos = transform.position;
        
        CreateGrid();
    }

    private void CreateGrid()
    {
        initPos = transform.position;

        float initX = initPos.x;
        
        for (int x = 0; x < xAxis; x++)
        {
            float initZ = initPos.z;
            
            for (int z = 0; z < zAxis; z++)
            {
                Vector3 newCubePos = new(initX, initPos.y, initZ);
                InstantiateCube(newCubePos);
                initZ += padding;
            }

            initX += padding;
        }
    }

    private void InstantiateCube(Vector3 newCubePos)
    {
        Instantiate(_cubePreFab, newCubePos, Quaternion.identity);
    }
    


}
