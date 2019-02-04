using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;

    private PlayerStats thePlayerStats;
    private Respawn Respawn;

    public int expToGive;

    public string enemyQuestName;
    private QuestManager theQM;


    public GameObject ItemnToSpawn;

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
        thePlayerStats = FindObjectOfType<PlayerStats>();
        theQM = FindObjectOfType<QuestManager>();
        Respawn = FindObjectOfType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {

            theQM.enemyKilled = enemyQuestName;

            Respawn.Wait();
         
            thePlayerStats.AddExperience(expToGive);

            Instantiate(ItemnToSpawn, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

            Destroy(gameObject);

        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
    
}