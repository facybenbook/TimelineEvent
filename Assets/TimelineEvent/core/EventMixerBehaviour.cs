﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

//// Mixer　PlayableBehaviour
public sealed class EventMixerBehaviour : PlayableBehaviour
{
    //public override void ProcessFrame(Playable playable, FrameData info, object playerData) {
    //    //Debug.LogError("ProcessFrame");
    //    // Trackから値を取得
    //    var rootGObj = (ScheduleActionBase)playerData;
    //    if (rootGObj == null) { return; }

    //    // PlayableBehaviour へ渡す
    //    int inputCount = playable.GetInputCount();
    //    for (int i = 0; i < inputCount; i++) {
    //        var inputPlayable = (ScriptPlayable<SchedulePlayableBehaviour>)playable.GetInput(i);
    //        SchedulePlayableBehaviour bhv = inputPlayable.GetBehaviour();
    //        bhv.bindObj = rootGObj;
    //    }
    //}
}