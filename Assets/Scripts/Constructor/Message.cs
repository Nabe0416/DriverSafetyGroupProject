using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Message
{
    public int MessageId;
    public string MessageContent;
    public List<Reply> Replies;
    public Chara Sender;

    public Message(int id, string ct, List<Reply> rpls, Chara sender)
    {
        this.MessageId = id;
        this.MessageContent = ct;
        this.Replies = rpls;
        this.Sender = sender;
    }

    public int GetId()
    {
        return this.MessageId;
    }

    public string GetContent()
    {
        return this.MessageContent;
    }

    public List<Reply> GetPossibleReplies()
    {
        return this.Replies;
    }

    public Chara GetSender()
    {
        return this.Sender;
    }
}

