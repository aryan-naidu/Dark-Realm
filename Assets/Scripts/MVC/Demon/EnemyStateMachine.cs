using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EEnemyStates
{
    Idle,
    Patroling,
    Chasing,
    Attacking,
    GettingHit
}

public class EnemyStateMachine
{
    private EEnemyStates _currentEnemyState;

    public EnemyStateMachine()
    {
        _currentEnemyState = EEnemyStates.Idle;
    }

    public void SetEnemyState(EEnemyStates state)
    {
        switch (state)
        {
            case EEnemyStates.Idle:
                _currentEnemyState = state;
                IdleStateBehaviour();
                break;
            case EEnemyStates.Patroling:
                _currentEnemyState = state;
                PatrolingStateBehaviour();
                break;
            case EEnemyStates.Chasing:
                _currentEnemyState = state;
                ChasingStateBehaviour();
                break;
            case EEnemyStates.Attacking:
                _currentEnemyState = state;
                AttackingStateBehaviour();
                break;
            case EEnemyStates.GettingHit:
                _currentEnemyState = state;
                GettingHitStateBehaviour();
                break;
        }
    }

    #region State Behaviours
    private void GettingHitStateBehaviour()
    {
        throw new NotImplementedException();
    }

    private void AttackingStateBehaviour()
    {
        throw new NotImplementedException();
    }

    private void ChasingStateBehaviour()
    {
        throw new NotImplementedException();
    }

    private void PatrolingStateBehaviour()
    {
        throw new NotImplementedException();
    }

    private void IdleStateBehaviour()
    {
        throw new NotImplementedException();
    }
    #endregion
}
