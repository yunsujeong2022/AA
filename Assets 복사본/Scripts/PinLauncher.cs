using UnityEngine;

public class PinLauncher : MonoBehaviour
{
    [SerializeField]
    private GameObject pinObject;

    private Pin currPin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PreparePin();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)
           && currPin != null
           && GameManager.instance.isGameOver==false){
           currPin.Launch();
           currPin = null;
           Invoke("PreparePin", 0.1f);
        }
    }

    void PreparePin(){
        if(GameManager.instance.isGameOver == false){
           GameObject pin =Instantiate(pinObject,transform.position,Quaternion.identity);
           currPin = pin.GetComponent<Pin>();
        }
    }

}
