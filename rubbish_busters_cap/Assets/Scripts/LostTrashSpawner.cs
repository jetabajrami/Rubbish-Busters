using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LostTrashSpawner : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI pointsTextResult;

    public GameObject[] lostObjectArray;


    void Start()
    {

        pointsTextResult.text = "Congratulation, you scored " + GlobalData.points.ToString() + "!...";

        //int randomIndex = Random.Range(0, Trash.Length);
        //GameObject currentObject = Instantiate(Trash[randomIndex], transform.position, Quaternion.identity);

        //LastTrashSpown();
    }


    //private void LastTrashSpown()
    //{
    //    //for (int i = 0; i < GlobalData.lostTrashIndex.Length; i++)
    //    //{
    //        //transform.position += new Vector3(0, 0, 0);
    //        GameObject currentObject = Instantiate(lostObjectArray[GlobalData.lostTrashIndex[0]], transform.position, Quaternion.identity);
    //        currentObject.transform.position = new Vector3(0, 0, 0);
    //    //}
    //}
}
