using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Update()
    {
        float fps = 1.0f/ Time.deltaTime;
        text.text = "FPS:" + fps;
    }


}
