namespace DBProject
{
    public class ComboboxItem
    {
        public ComboboxItem(string Text, string Value)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
