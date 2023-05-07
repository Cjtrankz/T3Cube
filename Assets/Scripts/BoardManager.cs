using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField]private GameObject PlayerSymbol;
    [SerializeField]private GameObject AISymbol;

    public List<string> AlreadyPicked = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //check if player is X or O, if X place an ai O first
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
