using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResultButtonManager : MonoBehaviour
{
    [SerializeField] GameObject _selectButton;
    private Vector3 _seleceScale;

    //�I����Ԃ��T�C�Y�̕ύX���p�̕ϐ�
    public float moveSpeed;  //�T�C�Y���ς��X�s�[�h

    public float scallSpeed;  //�T�C�Y���ς��X�s�[�h
    public float maxTime;  //�傫�����ő�ɂȂ鎞��
    private float time;  //���Ԃ̕ۑ��p�ϐ�
    private bool enlarge = true;

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(_selectButton);

        _seleceScale = _selectButton.transform.localScale;

        _selectButton.transform.localScale = Reset_ImageScale(_seleceScale);
    }

    // Update is called once per frame
    void Update()
    {
        Scaling(_selectButton);
    }

    //�g��k���̉��o�̏��� : Processing of scaling direction
    void Scaling(GameObject image)
    {
        scallSpeed = Time.deltaTime * 0.01f;

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
