using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawm=1;
    public float tileLength=20;
    public int no_Tiles=5;
    public Transform playerTreansform; 
    private List<GameObject> activeTiles=new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SpawmTile(0);
        for(int i=0;i<no_Tiles;i++)
        {
            SpawmTile(Random.Range(1,tilePrefabs.Length));
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
     if (playerTreansform.position.z>zSpawm-(no_Tiles*tileLength)){
        SpawmTile(Random.Range(1,tilePrefabs.Length));
        DeleteTile();
     }   
    }
    public void SpawmTile(int tileIndex){

        GameObject go=Instantiate(tilePrefabs[tileIndex],transform.forward*zSpawm,transform.rotation);
        activeTiles.Add(go);
        zSpawm=zSpawm+tileLength;
    }
    private void DeleteTile(){
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
