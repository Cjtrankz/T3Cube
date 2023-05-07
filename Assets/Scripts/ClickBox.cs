using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBox : MonoBehaviour
{
    [SerializeField]public GameObject Board;
    private List<string> placeList = new List<string>();
    //public BoardMangager boardManager;

    [SerializeField]private int XCoord;
    [SerializeField]private int YCoord;
    
    public GameObject player;

    //make player the reference in board manager for X or O

    // Start is called before the first frame update
    void Start()
    {
        //boardManager = Board.GetComponent<BoardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(this.transform.childCount <= 0)
        {
        Instantiate(player, this.transform);
        }

        placeList.Add("1");
        placeList.Add("2");
        foreach(var a in placeList)
        {
        Debug.Log(a);
        }

        //Board.GetComponent<List>().AlreadyPicked.Add("O");
        //placeList = GetComponentInParent(AlreadyPicked);
        //add the X or O piece to an array
    
        //CheckWinner();
        //check if the arrays have 3 of the same value (X/O), declare that value the winner?
    
        //add ai piece here    
    }

    private void CheckWinner()
    {
        //
    }
}
