using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public Vector2Int headIndex;
    public Vector2Int direction;

    public Vector2Int currentGridIndex;

    public float moveSpeed = 1f;
    public float gridSize = 1f;

    private Vector3 targetPosition;

    void Start()
    {
        //targetPosition = transform.position;

        //--------
        currentGridIndex = new Vector2Int(7, 7);
        transform.position = Grid.GetTileWorldPos(currentGridIndex);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Move(Vector3.forward);
            Move(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Move(Vector3.back);
            Move(Vector3.down);
        }
    }

    void Move(Vector3 direction)
    {
        Vector2Int dirIndex = new Vector2Int((int)direction.x, (int)direction.y);
        
        Vector2Int newGridIndex = currentGridIndex + dirIndex;
        transform.position = Grid.GetTileWorldPos(newGridIndex);
        
        currentGridIndex = newGridIndex;

        //Vector3 newPosition = targetPosition + direction * gridSize;
        // Check if the new position is within the grid boundaries
        // if (IsValidPosition(newPosition))
        // {
        //     targetPosition = newPosition;
        // }
    }

    bool IsValidPosition(Vector3 position)
    {
        // Check if the position is within the grid boundaries
        // You can add your own logic or conditions here if needed
        return true;
    }

    void FixedUpdate()
    {
        // transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.fixedDeltaTime);
    }


    // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //    //if( Input.GetKeyDown(KeyCode.UpArrow))
    // }
}