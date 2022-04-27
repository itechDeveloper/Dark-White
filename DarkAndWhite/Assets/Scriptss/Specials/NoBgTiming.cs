using System.Collections;
using UnityEngine;

public class NoBgTiming : MonoBehaviour
{
    public NoBackGround bgno;
    public bool bgnoo;
    public Clock clock;

    // Update is called once per frame
    void Update()
    {
        if (bgnoo == true)
        {
            StartCoroutine(ActivateCoin());
        }
    }

    IEnumerator ActivateCoin()
    {
        bgno.specialplatform = true;
        yield return new WaitForSeconds(5f);
        if (clock.warningNoBg)
        {
            yield return new WaitForSeconds(.2f);
            clock.warningNoBg = false;
        }
        if (!clock.warningNoBg)
        {
            yield return new WaitForSeconds(.2f);
            clock.warningNoBg = true;
        }
        yield return new WaitForSeconds(2f);
        clock.warningNoBg = false;
        clock.activeNoBg = false;
        bgno.specialplatform = false;
        bgnoo = false;
    }
}