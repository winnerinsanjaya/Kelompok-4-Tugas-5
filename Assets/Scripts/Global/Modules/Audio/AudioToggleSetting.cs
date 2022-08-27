using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Paintastic.Global.Modules.SaveData;

namespace Paintastic.Global.Modules.Audio
{
    public class AudioToggleSetting : MonoBehaviour
    {
        public static Action<bool> OnToggleBgmClick;
        public static Action OnToggleSoundFXClick;

        [SerializeField] private enum ButtonType { ButtonBGM, ButtonSoundFX }
        [SerializeField] private Vector3 _onBtnPos;
        [SerializeField] private Vector3 _offBtnPos;
        [SerializeField] private GameObject _controlBgmButton;

        public Vector3 _currentBgmButtonPos;
        private Vector3 _currentSoundFXButtonPos;
        private bool isBgmOn = true;

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void SetCurrentBtnBgmPos()
        {
            if (isBgmOn == true)
            {
                _controlBgmButton.GetComponent<RectTransform>().anchoredPosition = _onBtnPos;
            }
            else if (isBgmOn == false)
            {
                _controlBgmButton.GetComponent<RectTransform>().anchoredPosition = _offBtnPos;
            }
        }

        void Start()
        {
            CheckBgmOn();
            SetCurrentBtnBgmPos();
        }

        void Update()
        {

        }

        public void ToggleBgm()
        {
            isBgmOn = !isBgmOn;
            OnToggleBgmClick(isBgmOn);
            if (isBgmOn)
            {
                _controlBgmButton.GetComponent<RectTransform>().anchoredPosition = _onBtnPos;
            }
            else if (!isBgmOn)
            {
                _controlBgmButton.GetComponent<RectTransform>().anchoredPosition = _offBtnPos;
            }
        }


        private void CheckBgmOn()
        {
            if (PlayerPrefs.GetInt("isAudioOn") == 1)
            {
                isBgmOn = true;
            }
            else if (PlayerPrefs.GetInt("isAudioOn") == 0)
            {
                isBgmOn = false;
            }
        }

    }

}
