/**** 
 * Created by: Thomas Nguyen
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Thomas Nguyen
 * Last Edited: April 6, 2022
 * 
 * Description: Projectile Behavior
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /***VARIABLES***/
    private BoundsCheck bndCheck; //reference to bounds check

    private void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    } //end Awake()

    // Start is called before the first frame update
    void Start()
    {
        
    } //end Start()

    // Update is called once per frame
    void Update()
    {
        if(bndCheck.offUp)
        {
            gameObject.SetActive(false);
            bndCheck.offUp = false; //reset the boundary settings
        }

    } //end Update()
}
