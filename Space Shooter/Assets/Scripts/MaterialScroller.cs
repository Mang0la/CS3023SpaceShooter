/**** 
 * Created by: Thomas Nguyen
 * Date Created: April 11, 2022
 * 
 * Last Edited by: Thomas Nguyen
 * Last Edited: April 11, 2022
 * 
 * Description: Scroll material by offset
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroller : MonoBehaviour
{
    private Material goMat; //the game object's material
    private Renderer goRenderer; //reference to object's mesh renderer
    
    public Vector2 scrollSpeed = new Vector2(0, 0); //x and y speed of scroll

    private Vector2 offset; //the offset of the scroll over time



    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMat = goRenderer.material;
    } //end Start()

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime);
        goMat.mainTextureOffset += offset;
    } //end Update()
}
