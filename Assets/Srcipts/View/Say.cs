using Game.Data;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using MyDialogs = Game.Data.Dialogs;

namespace Game.View
{


    public class Say : MonoBehaviour
    {
        [SerializeField] private MyDialogs _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Choise _choise;

        private int _index;

        private void Start()
        {
            if (_dialogs != null) NextDialog();
        }
        public void NextDialog()
        {
            if (_index == _dialogs.Get.Length) return;

            _name.SetText(_dialogs.Get[_index].Name);
            _text.SetText(_dialogs.Get[_index].Text);

            
            _index++;
        }

        private void ChoiseCreate()
        {
            if (_dialogs.Get[_index].choises.Length != 0)
                foreach (MyDialogs.ChoiseElement element in _dialogs.Get[_index].choises)
                    _choise.Add(element);
        }
        public void Choise(ChoiseButton choiseButton)
        {
            _index = 0;
            _dialogs = choiseButton.Dialogs;
            choiseButton.Hide();
            _choise.Hide();
        }
    }
}
