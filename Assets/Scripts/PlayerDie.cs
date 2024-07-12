using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endpanel;
    private string Enemy = "Enemy";
    private string BadGuy = "BadGuy";
    private string EnemyBullet = "Enemy Bullet";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == Enemy)
        {
            endpanel.SetActive(true);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == EnemyBullet)
        {
            endpanel.SetActive(true);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == BadGuy)
        {
            endpanel.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
