using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SpawnTrash : MonoBehaviour
{
    public GameObject[] Trash;
    public GameObject lostPointText;
    public GameObject uiObject;
   [SerializeField] TextMeshProUGUI pointsText;
   [SerializeField] public TextMeshProUGUI trashNameText;
   
    public GameObject lifeOne;
    public GameObject lifeTwo;
    public GameObject lifeThree;


    //public int points = 0;
    public int lostPoint = 1;


    // Start is called before the first frame update
    public GameObject Start()
    {
        return NewTrash();
    }

    public GameObject NewTrash()
    {
        int randomIndex = Random.Range(0, Trash.Length);
        GameObject currentObject = Instantiate(Trash[randomIndex], transform.position, Quaternion.identity);
        GlobalData.currentTrashIndex = randomIndex;
        GlobalData.currentTrashObj = currentObject;
        trashNameText.text = Trash[randomIndex].name;
        pointsText.text = GlobalData.points.ToString();
        Debug.Log(GlobalData.points);
        return currentObject;
    }
}
