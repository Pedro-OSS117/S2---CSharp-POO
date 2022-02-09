namespace Exo2
{
    public class Dictionary : Document
    {
        public enum Language
        {
            English,
            French,
            German,
            Spanish
        }

        private Language _language;

        public Dictionary(int registerNumber, string title, Language language) : base(registerNumber, title)
        {
            _language = language;
        }

        public override string ToString()
        {
            return  base.ToString() + $", Language : {_language}";
        }
    }
}