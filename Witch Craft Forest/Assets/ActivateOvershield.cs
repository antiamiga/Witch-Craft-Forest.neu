using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// weiterer Code hierzu in Obsticle (Kollision) und Player (Farbe und Timer des OverShields)
public class ActivateOvershield : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.isOverShieldActive = true;
            player.StartCoroutine(player.SetResetTimer());
            Destroy(gameObject);
        }
    }
}
