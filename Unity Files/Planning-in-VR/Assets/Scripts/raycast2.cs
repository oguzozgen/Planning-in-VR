using UnityEngine;
using System.Collections;

public class raycast2 : MonoBehaviour {

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetKey(KeyCode.Space))
        {
             if (Physics.Raycast(ray, 100))
             {
                 GameObject g = hit.collider.gameObject; string name = g.name; 
            print("Hit something!" +name);
            
        }

        if (Physics.Raycast(ray, out hit, 100))
            Debug.DrawLine(ray.origin, hit.point); 
        } 
       
      
    }
}
