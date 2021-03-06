﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP;
using KSPAchievements;
using KSP.Localization;

namespace ContractConfigurator
{
    /// <summary>
    /// ContractRequirement to provide requirement for player having had a crew recovered.
    /// </summary>
    public class FirstCrewToSurviveRequirement : ContractRequirement
    {
        public override bool RequirementMet(ConfiguredContract contract)
        {
            return ProgressTracking.Instance.firstCrewToSurvive.IsComplete;
        }

        public override void OnLoad(ConfigNode configNode) { }
        public override void OnSave(ConfigNode configNode) { }

        protected override string RequirementText()
        {
            return Localizer.GetStringByTag(invertRequirement ? "#cc.req.FirstCrewToSurvive.x" : "#cc.req.FirstCrewToSurvive");
        }
    }
}
