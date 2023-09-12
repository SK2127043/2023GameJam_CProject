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

    // ESC�L�[�������ꂽ�Ƃ��ɕ\������p�l��
    [SerializeField] GameObject _endPanel;

    // �{�^����I����Ԃɂ��Ă����I�u�W�F�N�g
    [SerializeField] GameObject _selectButton;

    public float soundVolume = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // ������
        _endPanel.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
    }

    // Update is called once per frame
    void Update()
    {
        // �J�E���g�_�E����ƑS�̂̎��ԓ���ESC�L�[���g�p�ł���悤�ɂ��鏈��
        if (_timeSystem.isCountDown&& !_timeSystem.isFinish && Input.GetKeyDown(KeyCode.Escape))
        {
            // ���ʂ��O�ɂ���
            _audioSource.volume = 0;

            // InGameSystem���g�p�ł��Ȃ�����
            _typeingSystem.SetActive(false);

            // �p�l����\������
            _endPanel.SetActive(true);

            // �Q�[�����̎��Ԃ��~�߂�
            Time.timeScale = 0f;

            // �ŏ��ɑI�����Ă����{�^����ݒ肷��
            EventSystem.current.SetSelectedGameObject(_selectButton);
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

        // audio�̃{�����[�����グ��
        _audioSource.volume = soundVolume;

        // �Q�[�����̎��Ԃ�i�߂�
        Time.timeScale = 1;
    }

}
