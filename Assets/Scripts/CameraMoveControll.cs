using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControll : MonoBehaviour
{
    //Tips
    //�u;�v�͓��{��̕��͂ɂ�����u�B�v�ƂȂ�܂��B
    //�u.�v�i�h�b�g�́j���{��̕��͂ɂ�����u�́v�Ȃǂ̐ڑ����ɂȂ�܂��B
    //�u{�p�v�͓��{��̕��͂ɂ������i���ɂȂ�܂��B
    //�uHogehoge()�v��Hogehoge�Ƃ����������s���Ƃ����Ӗ��ƂȂ�܂��B
    //���i���j�t�@���N�V�����Ƃ����Ӗ��ł�����܂��B
    //�u=�v�͑���ł��B�u==�v�͐��w�I�ȁ��Ɠ����Ӗ��ƂȂ�܂��B
    //�u+,-,/*�v���Z�A���Z�A���Z�A�|���Z�͂��̂܂܂̈Ӗ��u���v�̗]����g�����Ƃ�����܂��B
    //�ϐ��͐��w�ł����Ƃ���́u���v�Ƃ��ł��B���g��ύX�ł���l�ƂȂ�܂��B
    //�v���O���~���O�̕ϐ��̓v���O���~���O�ň����S�Ă̌^���������Ƃ��ł��܂��B
    //�^��ϐ��Ƃ��Đ錾����i��`����j���Ƃ��ł��܂��B

    /// <summary>
    /// �J�����̈ʒu�A��]�A�g�k���i�[���ꂽTransform�^�̕ϐ�
    /// </summary>
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        //�錾�����ϐ��ɂ��̃R���|�[�l���g���ǉ����ꂽGameObject��Transform��������
        cameraTransform =  this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����̈ʒu���ɁA�E�����̃x�N�g���Ƀt���[�����Ԃ��|�����l�����Z��������
        //deltaTime = CPU������������t���[���̎��̃t���[���܂ł̎���
        //�t���[���Ƃ́H1�b�Ԃɉ���`�悪�X�V����邩�̒l�B60fps�̃Q�[���̏ꍇ�͈�b�Ԃ�60��A�����A�`�悪�X�V����܂��B
        //frame per second�̗��ł��B
        //60fps��Time.deltaTime�͌������Ԃ�0.0166�b�Ƃ����l
        //30fps��Time.deltaTime�͌������Ԃ�0.0333�b�Ƃ����l

        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}
