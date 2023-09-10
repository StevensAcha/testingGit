using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class CharactersSelection : MonoBehaviour
{
    public GameObject[] charactersSelection;
    public GameObject characterSelector;
    public GameObject[] enemiesSelection;
    public GameObject enemySelector;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectYourCharacter(enemySelector, enemiesSelection);
        }
        else
        {
            SelectYourCharacter(characterSelector, charactersSelection);
        }
    }
    public void SelectYourCharacter(GameObject selector, GameObject[] selectionArray)
    {

        UnityEngine.Vector3 characterPosition = selectionArray[index].transform.position;
        selector.transform.position = new UnityEngine.Vector3(selector.transform.position.x, selector.transform.position.y, characterPosition.z);
        if(Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.DownArrow)){
            if(index < selectionArray.Length -1){
                index++ ;
            }
            else{
                index = 0;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.UpArrow)){
            if(index > 0){
                index--;
            }
            else{
                index = selectionArray.Length-1;
            }
        }
        
    }

}
