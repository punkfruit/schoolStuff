using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idobj;
    public UnityEvent matchEvent, noMatchEvent, noMatchEventDelayed;

    private IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        
        var tempOBJ = other.gameObject.GetComponent<IDcontainer>();
        if (tempOBJ == null)
            yield break;

        var otherID = tempOBJ.IDOBJ;

        if(otherID == idobj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchEventDelayed.Invoke();
        }
    }
}
