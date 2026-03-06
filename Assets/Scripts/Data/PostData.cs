namespace Data
{
    [System.Serializable]
    public class PostData
    {
        public string name;
        public string address;
        public string hashtags;
        public string image;
    }

    [System.Serializable]
    public class PostList
    {
        public PostData[] posts;
    }
}
