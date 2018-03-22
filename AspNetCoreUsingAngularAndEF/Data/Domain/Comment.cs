namespace AspNetCoreUsingAngularAndEF.Data.Domain
{
    public class Comment
    {
        public string CommentText { get; set; }

        public virtual Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}