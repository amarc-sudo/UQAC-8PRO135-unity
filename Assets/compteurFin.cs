using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compteurFin : MonoBehaviour
{
    public int nb = 3;

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


            yield return new WaitForSeconds(1f);

            nb--;

        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
