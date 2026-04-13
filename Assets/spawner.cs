using UnityEngine;
using UnityEngine.Pool;

public class spawner : MonoBehaviour
{
      [SerializeField] private Transform spawnPoint;
        [SerializeField] private float timeBetweenSpawns;
        [SerializeField] private GameObject castleGuard02Prefab;
        private float timesinceLastSpawn;
        
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timesinceLastSpawn)
        {
            timesinceLastSpawn = Time.time + timeBetweenSpawns;
            SpawnCastleGuard();
        }
    }

    void SpawnCastleGuard()
    {
        if (castleGuard02Prefab != null && spawnPoint != null)
        {
            Instantiate(castleGuard02Prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
