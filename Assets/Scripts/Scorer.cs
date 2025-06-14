using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;
    
    private void OnCollisionEnter(Collision collision)
    {
        hit++;
        Debug.Log("Uhm You Kinda Bumped Into Objects " + hit + " Times");
    }
}
