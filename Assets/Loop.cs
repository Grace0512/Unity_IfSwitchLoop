using UnityEngine;

public class Loop : MonoBehaviour
{

    public GameObject cube;
    void Start()
    {
        SetTriangle();
    }

    
    void Update()
    {
        
    }

    void SetTriangle()
    {
        for(int i = 0; i <= 10; i++)
        {
            for(int j=0;j<i;j++)
            {
                Instantiate(cube, new Vector3(i * 2+1000, j*2+500, -200), Quaternion.Euler(0, 0, 0));
            }
            
        }
    }
}
