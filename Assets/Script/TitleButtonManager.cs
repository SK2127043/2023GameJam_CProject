using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TitleButtonManager : MonoBehaviour
{
    [SerializeField] GameObject[] _selectButton=new GameObject[2];
    private Vector3[] _seleceScale = new Vector3[2]; 
    
    private GameObject _button;

    //�I����Ԃ��T�C�Y�̕ύX���p�̕ϐ�
    public float scallSpeed;  //�T�C�Y���ς��X�s�[�h
    public float maxTime;  //�傫�����ő�ɂȂ鎞��
    private float time;  //���Ԃ̕ۑ��p�ϐ�
    private bool enlarge = true;

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(_selectButton[0]);

        for (int i = 0; i < _selectButton.Length; i++)
        {
            _seleceScale[i] = _selectButton[i].transform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _button = EventSystem.current.currentSelectedGameObject;

        if (_button == _selectButton[0])
        {
            Scaling(_selectButton[0]);
            _selectButton[1].transform.localScale = Reset_ImageScale(_seleceScale[1]);
        }
        if (_button == _selectButton[1])
        {
            Scaling(_selectButton[1]);
            _selectButton[0].transform.localScale = Reset_ImageScale(_seleceScale[0]);
        }
    }

    //�g��k���̉��o�̏��� : Processing of scaling direction
    void Scaling(GameObject image)
    {
        scallSpeed = Time.deltaTime * 0.1f;

        if (time < 0) { enlarge = true; }
        if (time > maxTime) { enlarge = false; }

        if (enlarge)
        {
            time += Time.deltaTime;
            image.transform.localScale += new Vector3(scallSpeed, scallSpeed, scallSpeed);
        }
        else
        {
            time -= Time.deltaTime;
            image.transform.localScale -= new Vector3(scallSpeed, scallSpeed, scallSpeed);
        }
    }

    //�傫���̏����� : Size initialization
    Vector3 Reset_ImageScale(Vector3 afterObj)
    {
        return afterObj;
    }
}
