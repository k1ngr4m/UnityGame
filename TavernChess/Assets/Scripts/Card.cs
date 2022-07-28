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
    public int id;      //编号
    public string cardName;     //卡牌名
    public CardType cardType;     //卡牌类型
    public string cardDescription;      //卡牌描述
    public Sprite cardSprite;   //卡牌图片

    public int cardLevel;       //卡牌等级
    public int cardAttack;      //卡牌攻击力
    public int cardHealth;      //卡牌生命值

    public bool isGolden;   //是否为三连
}
