using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 7; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Instantiate(cube, new Vector3(0, 7 - i, 7 - i) + new Vector3(j, 0, j), Quaternion.identity);
            }
        }
    }


}
