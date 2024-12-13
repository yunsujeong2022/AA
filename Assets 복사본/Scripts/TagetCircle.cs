using UnityEngine;

public class Scripts : MonoBehaviour
{
    [SerializeField]

    private float rotateSpeed = -30f; //시계방향 (음수),반시계방향 (양수);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(GameManager.instance.isGameOver == false){
        transform.Rotate(0,0,rotateSpeed*Time.deltaTime);
    }
    }
}
