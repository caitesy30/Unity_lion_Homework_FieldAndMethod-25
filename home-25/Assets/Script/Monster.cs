
using UnityEngine;
/// <summary>
/// �Ǫ����O
/// �x�s�Ǫ����
/// </summary>

public class Monster : MonoBehaviour
{
    [Header("�򥻯�O"),Range(0,10)]
    public float movespeed=3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [Range(0, 5000)]
    public float hp = 350;
    [Range(0,50)]
    public float rangetrack =30f;
    public Vector3 offsetTrack;
    
    [Header("�����D��ξ��v")]
    public GameObject Prop;
    [Range(0, 1)]
    public float Probability=1;

    [Header("���ĳ]�w")]
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
