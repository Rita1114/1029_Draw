using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
// A behaviour that is attached to a playable
public class NewPlayableBehaviour : PlayableBehaviour
{
    [Header("对话框")]
    public ExposedReference<Text> Dialog;
    private Text _dialog;
    [Multiline(3)]
    public string DialogStr;

    public override void OnGraphStart(Playable playable)
    {
        _dialog = Dialog.Resolve(playable.GetGraph().GetResolver());
    }

    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {

        _dialog.gameObject.SetActive(true);
        _dialog.text = DialogStr;
    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        if (_dialog)
        {
            _dialog.gameObject.SetActive(false);
        }
    }
}
