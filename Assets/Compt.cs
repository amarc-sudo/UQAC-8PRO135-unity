using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compt : MonoBehaviour
{
    public int nb = 2;
    public Text text;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Countdown());
    }

    public IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1f);

        while (nb > 0)
        {
            text.text = nb.ToString();


            yield return new WaitForSeconds(1f);

            nb--;
                
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("level2");
    }
}
