using System.Dynamic;
using UnityEngine;

public class NewMonoBehaviourScript2 : MonoBehaviour
{
    
    public float expansionRate = 0.1f;
    // Tto control the speed of expansion. updated once per frame
    void Update()
    {
        transform.localScale += new Vector3(expansionRate, expansionRate, expansionRate) * Time.deltaTime;
    }
}