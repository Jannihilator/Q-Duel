using UnityEngine;

public class CubeController : MonoBehaviour
{
    // [SerializeField] Material flippedMaterial;
    MeshRenderer meshRenderer;
    GameManager gameManager;
    Color flippedColor2 = new Color(0.5284315f, 1, 0.2352941f);
    Color flippedColor1 = new Color(1, 0.2352941f, 0.3922811f);
    Color originalColor;
    int colorState = 0;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (colorState > -1 && other.CompareTag("Player1"))
        {
            colorState--;
            if (colorState == -1)
            {
                gameManager.CountScore(1);
            }
            if (colorState == 0)
            {
                gameManager.CountScore(2);
            }
        }
        if (colorState < 1 && other.CompareTag("Player2"))
        {
            colorState++;
            if (colorState == 1)
            {
                gameManager.CountScore(3);
            }
            if (colorState == 0)
            {
                gameManager.CountScore(4);
            }
        }
        if (colorState != 0 && other.CompareTag("Blue"))
        {
            if (colorState == 1)
            {
                gameManager.CountScore(2);
            }
            if (colorState == -1)
            {
                gameManager.CountScore(4);
            }
            colorState = 0;
        }
        switch (colorState)
        {
            case -1:
                meshRenderer.material.color = flippedColor1;
                break;
            case 0:
                meshRenderer.material.color = originalColor;
                break;
            case 1:
                meshRenderer.material.color = flippedColor2;
                break;
        }
    }
}
