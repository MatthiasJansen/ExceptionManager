﻿#region headers

// Copyright (c) 2017 Matthias Jansen
// See the LICENSE file in the project root for more information.

#endregion

#region imports

using System;
using System.Collections.Generic;
using ExceptionShield.Policies;

#endregion

namespace ExceptionShield.Strategies
{
    public interface IPolicyMatchingStrategy
    {
        ExceptionPolicyBase MatchPolicy(IReadOnlyDictionary<Type, ExceptionPolicyGroupBase> policyDictionary, Type type,
            string context);
    }
}