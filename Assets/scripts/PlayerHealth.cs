using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int max_health = 100;
    public int current_health = 100;

    public Slider health_bar;
    public bool is_dead => current_health <= 0;

    private void Start()
    {
        current_health = max_health;
        Update_Health_bar();
    }

    private void Update_Health_bar()
    {
        health_bar.maxValue = max_health;
        health_bar.value = current_health;

    }

    public void Take_Damage(int damage)
    {
        if (is_dead)
        {
            return;
        }

        current_health -= damage;

        Update_Health_bar();

        if (is_dead)
        {
            Die(); 
        }
    }

    private void Die()
    {
        Debug.Log("Player is dead :(");
        //aktywacja planszy game over
    }
}