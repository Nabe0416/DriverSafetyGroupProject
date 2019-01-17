using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charas : MonoBehaviour
{
    public List<Chara> CharacterList = new List<Chara>();

    private void Awake()
    {
        InstantiateCharasList();
    }

    void InstantiateCharasList()
    {
        CharacterList.Add(new Chara(0, null, "Mother", "+316XXXXXXXX"));
        CharacterList.Add(new Chara(1, null, "Eric", "+316XXXXXXXX"));
        CharacterList.Add(new Chara(2, null, "Pablo", "+316XXXXXXXX"));
    }
}
