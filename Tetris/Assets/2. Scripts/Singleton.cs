using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;
    //랜덤 블럭
    public int Tetris;

    public bool count;
    public float ShotPower;
    //캐릭터 위치 변경
    public bool CharMove;
    //캐릭터 애니메이션
    public bool isAnimChar = false;
    //발사 가능
    public bool isAttack = true;
    //점수
    public int Score = 0;
    //회전
    public bool RTurn;
    public bool LTurn;
    //드래그 가능
    public bool CanAttack;
    //애니메이션 캐릭터 가능
    public bool isAnimTr;
    //피버 카운트
    public int Fevercount;
    //위로 올라가는 버튼 활성화
    public bool isUpCharButton;
    //위로 올라가는 확인 하고 오브젝트 위로 이동
    public bool isTetrisMoveUp;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static Singleton Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
}