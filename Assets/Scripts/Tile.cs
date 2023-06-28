using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    public Vector2Int index;
    public bool isOccupied;
    public TextMeshPro debugText;
    
    // Start is called before the first frame update
    void Start()
    {
        debugText.text = index.ToString();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
