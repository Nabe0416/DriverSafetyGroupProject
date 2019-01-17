using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replies : MonoBehaviour
{
    public List<Reply> RepliesList1 = new List<Reply>();
    public List<Reply> RepliesList2 = new List<Reply>();
    public List<Reply> RepliesList3 = new List<Reply>();

    private void Awake()
    {
        InstantiateRepliesList1();
        InstantiateRepliesList2();
        InstantiateRepliesList3();
    }

    void InstantiateRepliesList1()
    {
        RepliesList1.Add(new Reply(0, "I've done that! I'm gonna see some friends now.", -1));
        RepliesList1.Add(new Reply(1, "Yeah, yeah. Will do that later.", -1));
        RepliesList1.Add(new Reply(2, "I get enought time to do that so leave me alone!", -1));
        RepliesList1.Add(new Reply(3, "Just gonna see some friend! I will do it after that, OK?", -1));
        RepliesList1.Add(new Reply(4, "NO!! I'm 22 now and I can decide for myself!", -1));
        RepliesList1.Add(new Reply(5, "Mom, please...", -1));
        RepliesList1.Add(new Reply(6, "Yeah, in a few hours.", -1));
        RepliesList1.Add(new Reply(7, "Sorry mom, I'll not be late!", -1));
        RepliesList1.Add(new Reply(8, "So what? I'm 22 now!", -1));
    }

    void InstantiateRepliesList2()
    {
        RepliesList2.Add(new Reply(0, "I'll be there in a min!!", -1));
        RepliesList2.Add(new Reply(1, "I'm on my way man! What happend?", -1));
        RepliesList2.Add(new Reply(2, "Traffic sucks man, how is he?", -1));
        RepliesList2.Add(new Reply(3, "Shit! Why did I missed that!!", -1));
        RepliesList2.Add(new Reply(4, "This stupid car won't go any faster!", -1));

    }

    void InstantiateRepliesList3()
    {
        RepliesList3.Add(new Reply(0, "No man, already there.", -1));
        RepliesList3.Add(new Reply(1, "Can you just man up for once??", -1));
        RepliesList3.Add(new Reply(2, "You really want me to turn around for that?", -1));
        RepliesList3.Add(new Reply(3, "Just kidding, I still had some with me.", -1));
        RepliesList3.Add(new Reply(4, "It's true though!", -1));
        RepliesList3.Add(new Reply(5, "I'll be there in a minute.", -1));
        RepliesList3.Add(new Reply(6, "So? Doesn' mean I'm wrong!", -1));
        RepliesList3.Add(new Reply(7, "Dude...", -1));
        RepliesList3.Add(new Reply(8, "Are you actually crying?", -1));
        RepliesList3.Add(new Reply(9, "Not a chance.", -1));
    }
}
