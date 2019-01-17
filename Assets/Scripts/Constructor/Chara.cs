using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Chara
{
    public int CharaId;
    public Image CharaIcon;
    public string CharaName;
    public string PhoneNumber;

    public Chara(int id, Image icon, string name, string num)
    {
        this.CharaId = id;
        this.CharaIcon = icon;
        this.CharaName = name;
        this.PhoneNumber = num;
    }

    public int GetId()
    {
        return this.CharaId; 
    }

    public Image GetIcon()
    { 
        return this.CharaIcon;
    }

    public string GetName()
    {
        return this.CharaName;
    }

    public string GetNumber()
    {
        return this.PhoneNumber;
    }
}