using UnityEngine;
using System.Collections;

public class EnemyStateMachine : MonoBehaviour {

    public enum State {Idle,Attack,Hit,Takeadump};
    public State myState;

	// Use this for initialization
	void Start () {
        myState = State.Idle;
	}
	
	// Update is called once per frame
	void Update () {
        /*switch (myState)
        {
            case State.Idle:
                IdleUpdate();
                break;
            case State.Attack:
                AttackUpdate();
                break;
            case State.Hit:
                HitUpdate();
                break;
            default:
                Debug.LogError("You're bad");
                break;
        }*/
        Invoke(myState.ToString() + "Update", 0.0f);
	}

    void IdleUpdate ()
    {
        Debug.Log("Idle Here");
    }

    void AttackUpdate ()
    {
        Debug.Log("Attack Here");
    }

    void HitUpdate ()
    {
        Debug.Log("Hit Here");
    }
}
