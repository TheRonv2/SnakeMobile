using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunkes = new List<Chunk> ();

    // Start is called before the first frame update
    void Start()
    {
        spawnedChunkes.Add(FirstChunk);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.z > spawnedChunkes[spawnedChunkes.Count - 1].End.position.z - 20)
        {
            SpawnChunk();
        }
    }

    public void SpawnChunk()
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = spawnedChunkes[spawnedChunkes.Count-1].End.position - newChunk.Begin.localPosition;
        spawnedChunkes.Add(newChunk);

        if (spawnedChunkes.Count >= 4)
        {
            Destroy(spawnedChunkes[0].gameObject);
            spawnedChunkes.RemoveAt(0);
        }
    }
}
