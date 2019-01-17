using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Reply
{
    public int ReplyId;
    public string Content;
    public int ReturningValue;

    public Reply(int id, string ct, int value)
    {
        this.ReplyId = id;
        this.Content = ct;
        this.ReturningValue = value;
    }

    public int GetId()
    {
        return this.ReplyId;
    }

    public string GetContent()
    {
        return this.Content;
    }

    public int GetReturningValue()
    {
        return this.ReturningValue;
    }
}
