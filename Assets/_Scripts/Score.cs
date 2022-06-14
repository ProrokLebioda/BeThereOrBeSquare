using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = playerTransform.position.z.ToString("0");
    }
}
