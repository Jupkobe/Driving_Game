using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Movement movement;
    public Horizontal horizontal;
    public GameObject[] roads;
    public float xSpawn = -100f;
    public float roadLenght = 100f;
    public bool isOver = false;
    public int counter = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "GameOver")
        {
            Debug.Log("Game Over!");
            movement.enabled = false;
            horizontal.enabled = false;
            isOver = true;
        }
        else if (collision.collider.tag == "WinCond")
        {
            Debug.Log("You Won!");
            movement.enabled = false;
            horizontal.enabled = false;
        }
        if (collision.collider.tag == "Road" && isOver == false)
        {
            spawnRoad(counter);
            counter++;
        }
    }

    public void spawnRoad (int roadNumber)
    {
        Instantiate(roads[roadNumber], transform.right * xSpawn, transform.rotation);
        xSpawn -= roadLenght;
    }
}
