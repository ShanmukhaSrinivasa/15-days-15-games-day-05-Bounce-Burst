using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameManager.instance.ScoreCount();
        Destroy(gameObject);
        GameManager.instance.GameComplete();
    }
}
