using System;
using System.Collections.Generic;
using System.Text;

namespace Composição.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
