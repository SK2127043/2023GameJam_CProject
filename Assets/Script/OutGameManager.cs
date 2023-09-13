using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OutGameManager : MonoBehaviour
{
    // �J�E���g�_�E���ƑS�̂̎��Ԃ̔�����g�p���邽�߂ɁuTimerManager�v���擾
    [SerializeField] public TimerManager _timeSystem;

    // �S�̂̎��Ԃ��I������ՂɃC���Q�[���������Ȃ��悤�ɂ��邽�߂ɁuInGameSystem�v���擾
    [SerializeField] GameObject _typeingSystem;

    // audio�̉��ʂ��������߂ɁuAudioSource�v���擾
    [SerializeField] AudioSource _audioSource;

    [SerializeField] AudioSource _bgmAudioSource;

    [SerializeField] AudioSource _poseAudioSource;

    // ESC�L�[�������ꂽ�Ƃ��ɕ\������p�l��
    [SerializeField] GameObject _endPanel;

    [SerializeField] GameObject[] _selectButton = new GameObject[3];

    public float soundVolume = 0.2f;

    [SerializeField] GameObject[] _backButton = new GameObject[3];

    private GameObject _button;

    public bool _isPose;

    // Start is called before the first frame update
    void Start()
    {
        // ������
        _endPanel.SetActive(false);

        _isPose = false;
    }

    // Update is called once per frame
    void Update()
    {
        _button = EventSystem.current.currentSelectedGameObject;
        // �J�E���g�_�E����ƑS�̂̎��ԓ���ESC�L�[���g�p�ł���悤�ɂ��鏈��
        if (_timeSystem.isCountDown&& !_timeSystem.isFinish && Input.GetKeyDown(KeyCode.Escape))
        {
            // �ŏ��ɑI�����Ă����{�^����ݒ肷��
            EventSystem.current.SetSelectedGameObject(_selectButton[0]);

            //_isPose = true;

            // ���ʂ��O�ɂ���
            _audioSource.volume = 0;
            _bgmAudioSource.volume = 0; 

            // InGameSystem���g�p�ł��Ȃ�����
            _typeingSystem.SetActive(false);

            // �p�l����\������
            _endPanel.SetActive(true);

            // �Q�[�����̎��Ԃ��~�߂�
            Time.timeScale = 0f;

            _poseAudioSource.Play();
        }

        if (_button == _selectButton[0])
        {
            _backButton[0].SetActive(false);
            _backButton[1].SetActive(true);
            _backButton[2].SetActive(true);
        }
        if (_button == _selectButton[1])
        {
            _backButton[1].SetActive(false);
            _backButton[0].SetActive(true);
            _backButton[2].SetActive(true);
        }
        if (_button == _selectButton[2])
        {
            _backButton[2].SetActive(false);
            _backButton[1].SetActive(true);
            _backButton[0].SetActive(true);
        }

        // �S�̂̎��Ԃ��I������ꍇ
        if (_timeSystem.isFinish)
        {
            // InGameSystem���g�p�ł��Ȃ�����
            _typeingSystem.SetActive(false);
        }
    }

    // Esc�L�[���������Ƃ��ɏo��u������RETUEN�v�̂��߂̊֐�
    public void OnClick_ReturnButton()
    {
        // �p�l�����\���ɂ���
        _endPanel.SetActive(false);

        // InGameSystem���g�p�ł���悤�ɂ���
        _typeingSystem.SetActive(true);

        _poseAudioSource.Stop();

        // audio�̃{�����[�����グ��
        _audioSource.volume = soundVolume;

        _bgmAudioSource.volume = 1;

        // �Q�[�����̎��Ԃ�i�߂�
        Time.timeScale = 1;
    }
}
