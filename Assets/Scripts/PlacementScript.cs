using UnityEngine;

public class PlacementScript : MonoBehaviour
{
    [SerializeField]
    private GameObject objToSpawn;

    [SerializeField]
    private GameObject spawner;

    private bool isSpawned;
    // Start is called before the first frame update
    void Start()
    {
        isSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (!isSpawned)
            {
                objToSpawn = Instantiate(objToSpawn, spawner.transform.position, spawner.transform.rotation);
                isSpawned = true;
            }
            else
            {
                objToSpawn.transform.position = spawner.transform.position;
            }
        }
    }
}
