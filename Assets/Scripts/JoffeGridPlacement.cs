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
    public float xRotation;
    public float yRotation;
    public float zRotation;
    public int tileCount;
    public bool spawnTiles;
    public bool offset;
    private Vector3 placementPosition = new Vector3(0, 0,0);
    // Start is called before the first frame update
    void Start()
    {
        // get the grid parent
        Grid = this.gameObject.transform;
        //  GridV2.x = Grid.position.x;
        //  GridV2.y = Grid.position.y;
        // list capacity is the gridX * the gridZ
       // gridSizeX += 10;
      //  gridSizeZ += 10;
        tiles.Capacity = gridSizeX * gridSizeZ ;
        
    }
    private void Update()
    {
        // while so it doesnt crash unity
        while (spawnTiles)
        {
            
            #region outerTles
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
                        clone = Instantiate(tilePrefab, Grid.position + placementPosition, Quaternion.Euler(xRotation, yRotation, zRotation), Grid);
                        tiles.Add(clone.transform);
                        // increase the placement pos.x by the tilespacing var
                        placementPosition.x += tileSpacing;
                        // increment tilecount and return it after incrementing
                       
                        ++tileCount;
                       
                    }
                    
                    offsetfunction();
                    offset = !offset;
                    // if counter is over gridZ set the placementpos.x to 0 and increase the placementpos.z by the tilespacing and reset counter
                    if (tileCount >= gridSizeZ )
                    {
                       
                        placementPosition.x = 0;
                        placementPosition.z += tileSpacing;                    
                        tileCount = 0;
                    }
                  
                    // set bool to false when the counter is <= the list capacity
                    if (tiles.Count <= tiles.Capacity)
                    {
                       // placementPosition.x = 0;
                      //  placementPosition.y = 0;
                      //  placementPosition.z = 0;
                        spawnTiles = false;
                      //  spawnInnerTiles = true;
                    }
                }
            }
        }
        #endregion
       
    }
   void offsetfunction()
    {
        if (offset == true)
        {
            placementPosition.x -= 2.5f;
            placementPosition.z += 2.5f;
            Debug.Log("increase");
        }
       else
        {
            placementPosition.x -= 2.5f;
            placementPosition.z -= 2.5f;
            Debug.Log("decrease");
        }
      
    }
}



