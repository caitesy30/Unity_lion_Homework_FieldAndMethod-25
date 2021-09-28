
using UnityEngine;
/// <summary>
/// 怪物類別
/// 儲存怪物資料
/// </summary>

public class Monster : MonoBehaviour
{
    [Header("基本能力"),Range(0,10)]
    public float movespeed=3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [Range(0, 5000)]
    public float hp = 350;
    [Range(0,50)]
    public float rangetrack =30f;
    public Vector3 offsetTrack;
    
    [Header("掉落道具及機率")]
    public GameObject Prop;
    [Range(0, 1)]
    public float Probability=1;

    [Header("音效設定")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig2D;
    private Animation ani;

    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
}
