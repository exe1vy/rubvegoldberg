using UnityEngine;
using TMPro;

public class text : MonoBehaviour

{
    public TMP_Text messageText;

    void OnCollisionEnter(Collision collision)
    {
        messageText.text = "What have you done...";
    }
}
