using UnityEngine;

public class Loop : MonoBehaviour
{

    public GameObject cube;
    void Start()
    {
        SetTriangle();
    }

    
   
    void SetTriangle()
    {
        for(int i = 0; i <= 10; i++)
        {
            for(int j=0;j<i;j++)
            {
                Instantiate(cube, new Vector3(i * 2, j*2,1 ), Quaternion.Euler(0, 0, 0));
            }
            
        }
    }
}


