using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager _gameManager;
    public float forwardSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private float firstTouchX;
    // Update is called once per frame
    void Update()
    {
        if(_gameManager.currentGameState !=GameState.Start)
        {
            return;
        }
        Vector3 moveVector = new Vector3(x: -15*forwardSpeed*Time.deltaTime, y: 0, z: 0);//ileri
        float diff = 0;
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchX = Input.mousePosition.x;

        }
        
        else if(Input.GetMouseButton(0))
        {
            float lastTouchX = Input.mousePosition.x;
            diff = lastTouchX-firstTouchX;
            moveVector += new Vector3(x:0, y: 0, z: diff * Time.deltaTime);
            firstTouchX=lastTouchX;
        }
        transform.position += moveVector;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectible"))
        {
            other.transform.SetParent(transform);

        }
    }

}
 