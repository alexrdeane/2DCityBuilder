using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoffeGridPlacement : MonoBehaviour
{
    public List<Transform> tiles;
    public Transform Grid;
    public GameObject tilePrefab;
    public int gridSizeX = 5;
    public int gridSizeZ = 5;
    public int tileSize = 2;
    public int tileSpacing =5;
    public bool spawnTiles;
    public int tileCount;
    public Vector3 placementPosition = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        // get the grid parent
        Grid = this.gameObject.transform;
        // list capacity is the gridX * the gridZ
        tiles.Capacity = gridSizeX * gridSizeZ;

    }
    private void Update()
    {
        // while so it doesnt crash unity
        while (spawnTiles)
        {
            // for loop for x 
            for (int x = 0; x < gridSizeX; x++)
            {
                // for loop for z
                for (int z = 0; z < gridSizeZ; z++)
                {
                    // if the counter is under the gridsizeX instantiate a prefab at the gridpos + the placement position and make the new prefab a child of the grid
                    if (tileCount <= gridSizeX)
                    {
                        GameObject clone;
                        clone = Instantiate(tilePrefab, Grid.position + placementPosition, Quaternion.identity,Grid);
                        tiles.Add(clone.transform);
                        // increase the placement pos.x by the tilespacing var
                        placementPosition.x += tileSpacing;
                        // increment tilecount and return it after incrementing
                        ++tileCount;
                    }
                    // if counter is over gridZ set the placementpos.x to 0 and increase the placementpos.z by the tilespacing and reset counter
                    if (tileCount >= gridSizeZ)
                    {
                        placementPosition.x = 0;
                        placementPosition.z += tileSpacing;
                        tileCount = 0;
                    }
                    // set bool to false when the counter is <= the list capacity
                    if (tiles.Count <= tiles.Capacity)
                    {
                        spawnTiles = false;
                    }
                }
            }
        }
    }
}



