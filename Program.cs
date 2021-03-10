using System;

namespace _311020
{
    class Program
    {
        private int x;
        private int y;
        private int tcount;
        private object label;

        public object Convent { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private void textBox1_Click(Object sender,EventArgs e)
        {
            TexBox t = new TexBox();
            t.Parent = this;
            t.Text = "Новое поле ввода";
            x = x + 10;
            y = y + 20;
            tcount = tcount + 1;
            label.Text = "Количество полей ввода=" + Convent.ToString(tcount);
        }
    }
}
