using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Tile tilePrefab;
    public int width = 50;
    public int height = 50;

    private static List<Tile> gameTiles = new List<Tile>();

    void Awake()
    {
        SpawnTiles();
    }

    void SpawnTiles()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 spawnPosition = new Vector3(x, y, 0);
                
                var tileObj = Instantiate(tilePrefab, spawnPosition, Quaternion.identity);
                Tile tile = tileObj.GetComponent<Tile>();
                tile.index = new Vector2Int(x, y);

                gameTiles.Add(tile);
            }
        }
    }

    public static Vector3 GetTileWorldPos(Vector2Int tileIndex)
    {
        foreach (var gameTile in gameTiles)
        {
            if (gameTile.index == tileIndex)
                return gameTile.transform.position;
        }

        print("invalid tile");
        return Vector3.zero;
    }
}