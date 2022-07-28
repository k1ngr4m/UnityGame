using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
public enum CardType
{
    demon,
    pirate,
    mechanical,
    dragon,
    Naga,
    beast,
    boar,
    fisher
}

public class Card
{
    public int id;      //���
    public string cardName;     //������
    public CardType cardType;     //��������
    public string cardDescription;      //��������
    public Sprite cardSprite;   //����ͼƬ

    public int cardLevel;       //���Ƶȼ�
    public int cardAttack;      //���ƹ�����
    public int cardHealth;      //��������ֵ

    public bool isGolden;   //�Ƿ�Ϊ����
}
