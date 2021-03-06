﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Develop.CQuery
{
    /// <summary>
    /// Global Condition Filter Result
    /// </summary>
    public class GlobalConditionFilterResult
    {
        /// <summary>
        /// condition
        /// </summary>
        public IQuery Condition
        {
            get; set;
        }

        /// <summary>
        /// append method
        /// </summary>
        public QueryOperator AppendMethod
        {
            get; set;
        }

        /// <summary>
        /// append origin query
        /// </summary>
        /// <param name="originQuery">origin query</param>
        public void AppendTo(IQuery originQuery)
        {
            originQuery?.SetGlobalCondition(Condition, AppendMethod);
        }
    }
}
