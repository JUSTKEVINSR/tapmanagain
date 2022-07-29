using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemColector : MonoBehaviour
{
    private int masonjar = 0;
    [SerializeField] private Text JarText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mason jar"))
        {
            Destroy(collision.gameObject);
            masonjar++;
            JarText.text = "Mason Jar: " + masonjar;
        }
    }


}
