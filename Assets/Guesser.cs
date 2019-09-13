using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guesser : MonoBehaviour
{
    public Image pokemon;
    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        pokemon.sprite = sprites[Random.Range(0, 5)];
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            pokemon.color = Color.white;
        }
    }
}
