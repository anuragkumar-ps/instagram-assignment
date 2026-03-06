using System;
using System.IO;
using Data;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    [SerializeField] private Transform postParent;
    [SerializeField] private GameObject postPrefab;

    private void Start()
    {
        LoadPosts();
    }

    private void LoadPosts()
    {
        var path = Path.Combine(Application.streamingAssetsPath, "posts.json");
        var json = File.ReadAllText(path);

        var postList = JsonUtility.FromJson<PostList>(json);

        foreach (var post in postList.posts)
        {
            var postObj = Instantiate(postPrefab, postParent);
            var ui = postObj.GetComponent<PostUI>();

            var image = Resources.Load<Sprite>("PostImages/" + post.image);
            ui.Setup(post, image);
        }
    }
}
