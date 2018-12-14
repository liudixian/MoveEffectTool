﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace MoveEffectTool
{
    public class Press_19 : BasePress
    {
        protected override void Effect()
        {
            transform.DOPunchRotation(new Vector3(0, 0, 30), 0.2f, 4, 0.5f);
        }
    }
}
