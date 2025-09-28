using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.IO;
using System.Transactions;
using Microsoft.VisualBasic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberComments()
    {
        return _comments.Count;
    }

    public string DisplayVideoInfo()
    {
        string videoInfo = $"Title: {_title} | Author: {_author} | Length {_lengthSeconds} seconds | Number of Comments: {GetNumberComments()}\n";
        videoInfo += "--- Comments ---\n";

        foreach (Comment comment in _comments)
        {
            videoInfo += comment.GetCommentDisplay() + "\n";
        }
        
        return videoInfo;
    }
}