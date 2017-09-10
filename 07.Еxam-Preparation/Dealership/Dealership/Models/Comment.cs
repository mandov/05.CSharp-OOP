namespace Dealership.Models
{
    using System;
    using Dealership.Common;
    using Dealership.Contracts;

    public class Comment : IComment
    {
        private string content;
        private string author;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            set
            {
                Validator.ValidateNull(value, Constants.CommentCannotBeNull);

                if (value.Length < Constants.MinCommentLength || value.Length > Constants.MaxCommentLength)
                {
                    throw new ArgumentException(string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
                }

                this.content = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                Validator.ValidateNull(value, "Author can not be null!");

                this.author = value;
            }
        }

        public override string ToString()
        {
            return string.Format("    ----------\n    {0}\n      User: {1}\n    ----------\n", this.Content, this.Author);
        }
    }
}