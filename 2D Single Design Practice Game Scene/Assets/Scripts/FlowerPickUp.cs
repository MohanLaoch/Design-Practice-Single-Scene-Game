using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerPickUp : MonoBehaviour
{
    
    [SerializeField] private Animator PlayerController;

    public static bool IsEnd;

    public GameObject PickedFlower;
    public GameObject GroundCrystals;
    public GameObject RealFlower;
    public GameObject Player;

    public GameObject FlowerIcon;

    public Transform teleportTarget;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RealFlower.SetActive(false); 
            IsEnd = true;
            StartCoroutine(EndSequence());
        }

        IEnumerator EndSequence()
        {
            PickedFlower.SetActive(true);
            GroundCrystals.SetActive(true);
            yield return new WaitForSeconds(1);
            Player.transform.position = teleportTarget.transform.position;
            PlayerController.SetBool("PickingFlower", true);
            yield return new WaitForSeconds(1.5f);
            PickedFlower.SetActive(false);
            FlowerIcon.SetActive(true);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            IsEnd = false;
        }
    }
    
    
}
