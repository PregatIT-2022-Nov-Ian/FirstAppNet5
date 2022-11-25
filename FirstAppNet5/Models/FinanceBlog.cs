using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppNet5.Models
{
    public class FinanceBlog : Blog
    {
        private List<string> _blogSource { get; set; }

        public void AddSource(string source) => _blogSource.Add(source);

        public IEnumerable<string> GetSources() => _blogSource;


        public FinanceBlog(string title, string description) : base(title, description)
        {            
            Console.WriteLine($"{nameof(FinanceBlog)} - Explicit constructor called.");
            _blogSource = new List<string>();

            StringBuilder sb = new StringBuilder();
            sb.Append("FINANCE");
            sb.Append(" - ");
            sb.Append(description);
            Description = sb.ToString();
        }

        public override void ShowBlog()
        {
            base.ShowBlog();
            ShowSources();
            Console.WriteLine("#############################");
        }

        public void ShowSources()
        {
            Console.WriteLine("Sources : ");
            foreach(var source in _blogSource)
            {
                Console.WriteLine(source);
            }
        }
    }
}
