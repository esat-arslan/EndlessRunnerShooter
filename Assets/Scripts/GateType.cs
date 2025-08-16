using UnityEngine;
using TMPro;

public class GateType : MonoBehaviour
{
    private TextMeshPro gateText;

    void Awake()
    {
        gateText = transform.Find("GateType").GetComponent<TextMeshPro>();
    }

    public void SetGateText(string newText)
    {
        if (gateText != null)
        {
            gateText.text = newText;
        }
    }
}
