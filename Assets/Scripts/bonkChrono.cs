using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonkChrono : MonoBehaviour
{

    public int nb = 4;

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

        UnityEngine.SceneManagement.SceneManager.LoadScene("level3");
    }
}
