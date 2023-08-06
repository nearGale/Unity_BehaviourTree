﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class Monitor : Parallel
    {
        public Monitor(Policy success, Policy failure) : base(success, failure)
        {

        }

        public void AddCondition(BTreeBehavior condition)
        {
            m_Children.Insert(0, condition);
        }

        public void AddAction(BTreeBehavior action)
        {
            m_Children.Add(action);
        }
    }
}