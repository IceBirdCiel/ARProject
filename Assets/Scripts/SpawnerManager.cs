using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField]
    public ARRaycastManager raycast;

    [SerializeField]
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycast.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
