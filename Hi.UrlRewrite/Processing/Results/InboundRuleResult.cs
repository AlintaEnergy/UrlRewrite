﻿using System;
using System.Web;
using Hi.UrlRewrite.Entities.Actions;

namespace Hi.UrlRewrite.Processing.Results
{

    public class InboundRuleResult : IRuleResult
    {
        public bool StopProcessing { get; set; }

        public Uri OriginalUri { get; set; }
        public Uri RewrittenUri { get; set; }

        public Guid ItemId { get; set; }
        public bool RuleMatched { get; set; }

        public IBaseAction ResultAction { get; set; }
        public ConditionMatchResult ConditionMatchResult { get; set; }
    }
}