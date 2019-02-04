using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{

    public int questNumber;

    public QuestManager theQM;

    public string startText;
    public string endText;

    public bool isItemnQuest;
    public string targetItem;

    public bool isEnemyQuest;
    public string targetEnemy;
    public int enemiesToKill;
    public int enemyKillCount;

    // Start is called before the first frame update
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isItemnQuest)
        {
            if(theQM.itemCollected == targetItem)
            {
                theQM.itemCollected = null;

                EndQuest();
            }    
        }

        if(isEnemyQuest)
        {
          if(theQM.enemyKilled == targetEnemy)
            {

                theQM.enemyKilled = null;

                    enemyKillCount++;
              
            }
          if(enemyKillCount - 1 >= enemiesToKill)
            {
                EndQuest();
            }
        }
    }
    public void StartQuest()
    {
        theQM.ShowQuestText(startText);

    }
    public void EndQuest()
    {
        theQM.ShowQuestText(endText);
        theQM.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
