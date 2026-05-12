using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static AllControl;

public class item_collector : MonoBehaviour
{
    //在下一场景中获取计分板数据
    int cherries;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.score = GameManager.Instance.totalscore;

        cherries = GameManager.Instance.score;
        cherriesText.text = "Cherries:" + cherries;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherries"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries:" + cherries;

            GameManager.Instance.totalscore = cherries;
        }
    }

    // Update is called once per frame

}
