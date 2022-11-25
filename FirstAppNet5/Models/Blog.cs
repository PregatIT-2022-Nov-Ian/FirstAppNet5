using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppNet5.Models
{
    public abstract class Blog : Entity<int>
    {
        private string _title;
        protected string _description;

        public string Title 
        { 
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DateTime CreatedAt { get; private set; }

        static Blog()
        {
            Console.WriteLine("Static constructor called.");
        }

        public Blog()
        {
            CreatedAt = DateTime.Now;
            Console.WriteLine($"{nameof(Blog)} - implicit constructor called");
        }

        public Blog(string title, string description) : this()
        {
            Title = title;
            Description = description;
        }

        public virtual void ShowBlog()
        {
            Console.WriteLine($"blog created at {CreatedAt.Date.ToShortDateString()}");
            Console.WriteLine($"Title : {this.Title}{Environment.NewLine}Description : {Description}");
        }
    }
}
