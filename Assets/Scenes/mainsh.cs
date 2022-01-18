using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;


public class mainsh : MonoBehaviour
{
    public Sprite kumai;
    public Sprite taninn;
    private Image DisplayImage;
    private Image DisplayImage2;
    // Start is called before the first frame update
    void Start()
    {
        DisplayImage = GameObject.Find("Image").GetComponent<Image> ();
        DisplayImage.sprite = kumai;
        DisplayImage2 = GameObject.Find("Image").GetComponent<Image> ();
        DisplayImage2.sprite = taninn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
