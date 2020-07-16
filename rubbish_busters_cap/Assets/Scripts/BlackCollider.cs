using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackCollider : MonoBehaviour
{

    public void Start()
    {
        FindObjectOfType<SpawnTrash>().uiObject.SetActive(false);
        FindObjectOfType<SpawnTrash>().lostPointText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     
        if (GlobalData.getBinColor(GlobalData.currentTrashObj.name) != "Black")
        {
            if (FindObjectOfType<SpawnTrash>().lostPoint <= 3)
            {
                FindObjectOfType<SpawnTrash>().uiObject.SetActive(false);
                FindObjectOfType<SpawnTrash>().lostPointText.GetComponent<lostBinText>().changeText(GlobalData.getBinName(GlobalData.currentTrashObj.name));
                FindObjectOfType<SpawnTrash>().lostPointText.SetActive(true);
                FindObjectOfType<SpawnTrash>().lostPoint += 1;

                if (FindObjectOfType<SpawnTrash>().lostPoint == 2)
                {
                    GlobalData.lostTrashIndex[0] = GlobalData.currentTrashIndex;
                    GlobalData.lostTrashObj[0] = GlobalData.currentTrashObj;
                    Destroy(FindObjectOfType<SpawnTrash>().lifeThree);
                }
                else if (FindObjectOfType<SpawnTrash>().lostPoint == 3)
                {
                    GlobalData.lostTrashIndex[1] = GlobalData.currentTrashIndex;
                    GlobalData.lostTrashObj[1] = GlobalData.currentTrashObj;
                    Destroy(FindObjectOfType<SpawnTrash>().lifeTwo);
                }
                else if (FindObjectOfType<SpawnTrash>().lostPoint == 4)
                {
                    GlobalData.lostTrashIndex[2] = GlobalData.currentTrashIndex;
                    GlobalData.lostTrashObj[2] = GlobalData.currentTrashObj;
                    Destroy(FindObjectOfType<SpawnTrash>().lifeOne);
                }
            }
            else if (FindObjectOfType<SpawnTrash>().lostPoint >= 3)
            {
                GlobalData.speed = 0.8f;
                SceneManager.LoadScene("Game Over");

            }
        }
        else if (GlobalData.getBinColor(GlobalData.currentTrashObj.name) == "Black")
        {
            FindObjectOfType<SpawnTrash>().lostPointText.SetActive(false);
            FindObjectOfType<SpawnTrash>().uiObject.SetActive(true);
            GlobalData.points += 100;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    GetComponent<AudioSource>().Play();
    //}
}