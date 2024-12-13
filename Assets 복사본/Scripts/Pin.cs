using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;

    private bool isPinned = false;
    private bool isLaunched = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isPinned==false&&isLaunched==true){
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        isPinned = true;
        if(other.gameObject.tag=="Target"){
            GameObject childObject = transform.Find("Square").gameObject;
            //GameObject childObject = transform.GetChild(0).gameObject;
            SpriteRenderer childSprite = childObject.GetComponent<SpriteRenderer>();
            childSprite.enabled = true;

            transform.SetParent(other.gameObject.transform);

            GameManager.instance.DecreaseGoal();
        }else if (other.gameObject.tag=="Pin"){
            GameManager.instance.SetGameOver(false);
        }
    }


    public void Launch(){
       isLaunched = true;
    }
}
