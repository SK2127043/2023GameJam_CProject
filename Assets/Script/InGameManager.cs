using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// ���Ԍv���̏���

public class InGameManager : MonoBehaviour
{
    // �J�E���g�_�E����\��������text���擾
    [SerializeField] TextMeshProUGUI countDown;
    // �J�E���g�_�E����\��������Text�̃I�u�W�F�N�g���擾
    [SerializeField] GameObject countObj;

    // �S�̂̎��Ԃ�\��������text���擾
    [SerializeField] TextMeshProUGUI lifeText;

    // �I����\��������text���擾
    [SerializeField] TextMeshProUGUI overText;
    // �I����\��������text�̃I�u�W�F�N�g���擾
    [SerializeField] GameObject overObj;

    // �V�[���J�ڂ����邽�߂ɁuTranstionManager�v���擾
    [SerializeField] public TranstionManager _transScene;

    // ���Ԍv������p�̕ϐ�
    private float _countDown = 3f;
    // �J�E���g�_�E���̐�����\�����邽�߂̕ϐ�
    private int _count;

    // Start�̕\������
    public int StartWaitTime;

    // Finish�̕\������
    public int FinishWaitTime;

    // �S�̂̎��Ԃ��v��
    public float lifeTime;
    // �S�̂̎��Ԃ̐�����\�����邽�߂̕ϐ�
    private int _life;

    // Start�ɓ���ۂ̉��o���I��������ǂ����̔���
    private bool _isCountDown;

    // �S�̂̎��Ԃ��I��������ǂ����̔���
    private bool _isFinish;

    // Start is called before the first frame update
    void Start()
    {
        // ������
        countObj.SetActive(true);
        overObj.SetActive(false);

        _count = 0;
        _life = 0;

        _isCountDown = false;
        _isFinish = false;
    }

    // Update is called once per frame
    void Update()
    {
        // �J�E���g�_�E���̏���
        if (_countDown >= 0)
        {
            // �J�E���g�_�E���R�b���玞�Ԃ����Z���Ă���
            _countDown-=Time.deltaTime;

            // text�ɕ\�����邽�߂�int�^�ɕϊ��B�������̕\�����R�Q�P�݂̂ɂ��������߂P�����Z
            _count = (int)_countDown+1;

            // text�Ō��݂̃J�E���g�_�E���̎c�莞�Ԃ�\��
            countDown.text= _count.ToString();
        }
        // _isCountDown�̔����t����̂́uStart�v���\������Ă��鎞�ɑS�̂̎��Ԃ��v������Ȃ��悤�ɂ��邽��
        if (!_isCountDown && _countDown <= 0)
        {
            // Start��\�����邽�߂̃R���[�`��
            StartCoroutine(Delay_StartText());
        }

        // �S�̂̎��Ԃ̏���
        // _isFinish�̔����t���Ă���̂́uFinish�v���\������Ă���Ƃ��ɑS�̂̎��Ԃ��v������Ȃ��悤�ɂ��邽��
        if (_isCountDown&&!_isFinish)
        {
            // �Q�[���S�̂̎��Ԃ����Z���Ă���
            lifeTime -= Time.deltaTime;

            _life = (int)lifeTime;

            // �Q�[���S�̂̎c�莞�Ԃ�\������
            lifeText.text = _life.ToString();
        }
        if (lifeTime <= 0)
        {
            // �S�̂̎��Ԃ��I������
            _isFinish = true;

            // Finish��\�����邽�߂̃R���[�`��
            StartCoroutine(Delay_OverText());
        }

    }

    // Start��\�����邽�߂̃R���[�`��
    private IEnumerator Delay_StartText()
    {
        // text�ɁuStart�v��\��
        countDown.text = "START!!";

        // text����莞�ԕ\�������܂܂ɂ���
        yield return new WaitForSeconds(StartWaitTime);

        // text�̃I�u�W�F�N�g���\���ɂ���
        countObj.SetActive(false);

        // �J�E���g�_�E�����I������
        _isCountDown = true;
    }

    // Finish��\�����邽�߂̃R���[�`��
    private IEnumerator Delay_OverText()
    {
        // text�̃I�u�W�F�N�g��\���ɂ���
        overObj.SetActive(true);

        // text�ɁuFinish�v��\��
        overText.text = "FINISH!!";

        // text����莞�ԕ\�������܂܂ɂ���
        yield return new WaitForSeconds(FinishWaitTime);

        // ���U���g��ʂ�J�ڂ���
        _transScene.To_Result();
    }
}
