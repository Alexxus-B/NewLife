using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Game.Data;
using MyDialogs = Game.Data.Dialogs;

namespace Game.View
{


    public class ChoiseButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Button _self;
        [SerializeField] private Say _say;

        public MyDialogs Dialogs { get; private set; }

        public void Show(MyDialogs.ChoiseElement choiseElement)
        {
            _text.SetText(choiseElement.Text);
            Dialogs = choiseElement.Dialogs;
            _self.onClick.AddListener(() => _say.Choise(this));
        }
        public void Hide() => Destroy(gameObject);
    }
}
