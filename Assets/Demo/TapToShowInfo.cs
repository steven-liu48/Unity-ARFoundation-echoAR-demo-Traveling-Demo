using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TapToShowInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject.name);
                if (hit.collider != null)
                {
                    TextMeshPro tm = hit.collider.gameObject.GetComponent<TextMeshPro>();
                    if (tm.enabled == false)
                    {
                        tm.enabled = true;
                    }
                    else
                    {
                        tm.enabled = false;
                    }
                }
            }
        }

#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject.name);
                if (hit.collider != null)
                {
                    TextMeshPro tm = hit.collider.gameObject.GetComponent<TextMeshPro>();
                    if (tm.enabled == false)
                    {
                        tm.enabled = true;
                    }
                    else
                    {
                        tm.enabled = false;
                    }
                }
            }
        }
#endif
    }
}
