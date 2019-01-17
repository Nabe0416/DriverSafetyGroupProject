using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messages : MonoBehaviour
{
    public List<Message> MessagesList1 = new List<Message>();
    public List<Message> MessagesList2 = new List<Message>();
    public List<Message> MessagesList3 = new List<Message>();

    private Replies replies;
    private Charas charas;

    private void Awake()
    {
        replies = this.GetComponent<Replies>();
        charas = this.GetComponent<Charas>();
    }

    List<Reply> GetPossibleReplies(int order, int[] id)
    {
        List<Reply> targetList;
        List<Reply> possibleReplies = new List<Reply>();
        switch (order)
        {
            case 1:
                targetList = replies.RepliesList1;
                break;
            case 2:
                targetList = replies.RepliesList2;
                break;
            case 3:
                targetList = replies.RepliesList3;
                break;
            default:
                Debug.LogError("Invalid target list index.");
                targetList = null;
                break;
        }
        if (targetList != null)
        {
            for (int i = 0; i < id.Length; i++)
            {
                possibleReplies.Add(targetList[id[i]]);
            }
        }
        else
        {
            possibleReplies = targetList;
        }

        return possibleReplies;
    }

    void InstantiateMessagesList1()
    {
        MessagesList1.Add(new Message(0, "Michael, where are you?? You have lots of homework to do!", GetPossibleReplies(1, new int[3] { 0, 1, 2 }), charas.CharacterList[0]));
        MessagesList1.Add(new Message(1, "What? Later?! Come home, NOW!!", GetPossibleReplies(1, new int[2] { 3, 4 }), charas.CharacterList[0]));
        MessagesList1.Add(new Message(2, "Not as long you live under my roof, get home NOW!!", GetPossibleReplies(1, new int[2] { 5, 6 }), charas.CharacterList[0]));
        MessagesList1.Add(new Message(3, "I'll not leave you alone. I'M YOUR MOTHER!!", GetPossibleReplies(1, new int[2] { 7, 8 }), charas.CharacterList[0]));
        MessagesList1.Add(new Message(4, "You still live under my roof so GET HOME NOW!!", GetPossibleReplies(1, new int[2] { 5, 7 }), charas.CharacterList[0]));
    }

    void InstantiateMessagesList2()
    {
        MessagesList2.Add(new Message(0, "Dude, WHERE ARE YOU?! This party is insane! Tim just puked all over the place. :)", GetPossibleReplies(2, new int[3] { 0, 1, 2 }), charas.CharacterList[1]));
        MessagesList2.Add(new Message(1, "It was sick man, you should have seen that.", GetPossibleReplies(2, new int[2] { 0, 3 }), charas.CharacterList[1]));
        MessagesList2.Add(new Message(2, "Don't know man, HURRY UP!!", GetPossibleReplies(0, null), charas.CharacterList[1]));
        MessagesList2.Add(new Message(3, "Still going!! It's hilarious, HURRY UP!!", GetPossibleReplies(2, new int[2] { 0, 4 }), charas.CharacterList[1]));
    }

    void InstantiateMessagesList3 ()
    {
        MessagesList3.Add(new Message(0, "Man, I feel sick. Can you bring me some painkillers?", GetPossibleReplies(3, new int[3] { 0, 1, 2 }), charas.CharacterList[3]));
        MessagesList3.Add(new Message(1, "Dude really...:(", GetPossibleReplies(3, new int[2] { 3, 4 }), charas.CharacterList[3]));
        MessagesList3.Add(new Message(2, "YOU AREN'T EVEN HERE YET!!", GetPossibleReplies(3, new int[2] { 5, 6 }), charas.CharacterList[3]));
        MessagesList3.Add(new Message(3, "Does mean you're missing this amazing party!!", GetPossibleReplies(0, null), charas.CharacterList[3]));
        MessagesList3.Add(new Message(4, "PLEASE, I'M DYING.", GetPossibleReplies(3, new int[2] { 7, 8 }), charas.CharacterList[3]));
        MessagesList3.Add(new Message(5, "You are going to get them or what??", GetPossibleReplies(3, new int[2] { 0, 9 }), charas.CharacterList[3]));
    }
}
