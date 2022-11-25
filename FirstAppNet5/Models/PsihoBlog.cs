using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppNet5.Models
{
    public class PsihoBlog : Blog
    {
        private IList<Comment> _comments; //composition

        public override void ShowBlog()
        {
            base.ShowBlog();
            Console.WriteLine("Psiho blog here ...");
            Console.WriteLine("#############################");
        }

        public new string Description
        {
            get { return _description; }
            set { _description = $"PSIHO - {value}"; }
        }
    }
}
